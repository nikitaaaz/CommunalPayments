using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CommunalPayments
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Charges : Window
    {

        DataGrid dg = new DataGrid();
        Connect con = new Connect();
        MainView mw = new MainView();
        ComboBox cb = new ComboBox();
        ComboBox cb1 = new ComboBox();
        public Charges()
        {
            InitializeComponent();
            FillComboboxes();
        }
        
        private void Row_DoubleClickOnSelectApartment(object sender, MouseButtonEventArgs e)
        {
            ApartmentChargesWindow cw = new ApartmentChargesWindow();
            DataRowView row = (DataRowView)dataGridSelApartment.SelectedItems[0];
            Connect.SelectApartmentNum = Convert.ToInt32(row[8]);
            string selApartment = "SELECT street_name, number_house, number_apartment, area, res_price, currency, date, name_tariff FROM result, apartment, tariff, houses, streets WHERE result.apartment = apartment.id_apartment AND streets.id_streets = houses.street AND apartment.house = houses.id_house AND result.tariff = tariff.id AND date >= '" + Connect.SelectDateStart + "' AND date <= '" + Connect.SelectDateStop + "' AND result.apartment = '"+ Connect.SelectApartmentNum +"'";
            string tabApartment = "result";
            dg = cw.DataGridViewApartmentCharge;
            con.ActionWithDB(selApartment, tabApartment, dg);
            cw.Show();
            
        }

        private void ViewResult()
        {
            string selApartment = "SELECT street_name, number_house, number_apartment, area, res_price, currency, date, name_tariff, id_apartment FROM result, apartment, tariff, houses, streets WHERE result.apartment = apartment.id_apartment AND streets.id_streets = houses.street AND apartment.house = houses.id_house AND result.tariff = tariff.id AND date >= '" + Connect.SelectDateStart + "' AND date <= '" + Connect.SelectDateStop + "'";
            string tabApartment = "result";
            dg = dataGridSelApartment;
            con.ActionWithDB(selApartment, tabApartment, dg);
            dg.Columns[8].Visibility = Visibility.Collapsed;
        }
    
        private void ComboDate_SelectionChanged_Start(object sender, SelectionChangedEventArgs e)
        {
            Connect.SelectDateStart = ComboDateStart.SelectedItem.ToString();
        }

        private void ComboDate_SelectionChanged_Stop(object sender, SelectionChangedEventArgs e)
        {
            Connect.SelectDateStop = ComboDateStop.SelectedItem.ToString();
        }

        private void FillComboboxes()
        {
            string command = "SELECT date_start FROM tariff";
            cb = ComboDateStart;
            cb1 = ComboDateStop;
            con.FillDataComboBoxses(command, cb);
            con.FillDataComboBoxses(command, cb1);
        }

        private void ButtonViewCharges_Click(object sender, RoutedEventArgs e)
        {
            ViewResult();
        }
    }
}
