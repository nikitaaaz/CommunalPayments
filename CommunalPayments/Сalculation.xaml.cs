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
using System.Data.SQLite;

namespace CommunalPayments
{
    /// <summary>
    /// Логика взаимодействия для Сalculation.xaml
    /// </summary>
    public partial class Сalculation : Window
    {

        DataGrid dg = new DataGrid();
        MainView mw = new MainView();
        Connect con = new Connect();
        ComboBox cb = new ComboBox();
        dataGridSelectTariff dataGridSelTarWindow = new dataGridSelectTariff();

        public Сalculation()
        {
            InitializeComponent();

            string selResult = "SELECT * FROM result";
            string tabResult = "result";
            dg = mw.dataGridDirectory;
            con.ActionWithDB(selResult, tabResult, dg);
            FillComboBox();

        }

        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            //получаем значение ячейки с площадью, в строке, по которой мы производим двойной щелчок
            DataRowView row = (DataRowView)DataGrigNoRes.SelectedItems[0];
            dataGridSelTarWindow.Show();
            Connect.apartment_id = Convert.ToInt32(row[0]);
            Connect.resPay = Convert.ToDouble(row[4]);
            this.Close();
        }

        private void ViewApartment()
        {

            string selResult = "SELECT id_apartment, street_name, number_house, number_apartment, area FROM apartment, houses, streets WHERE id_apartment NOT IN (SELECT apartment FROM result WHERE date='" + Connect.selectDate + "') AND streets.id_streets = houses.street AND apartment.house = houses.id_house";
            string tabResult = "apartment";
            dg = DataGrigNoRes;
            con.ActionWithDB(selResult, tabResult, dg);
        }

        private void FillComboBox()
        {
            //привязка данных с месяцем тарифа к ComboBox
            string command = "SELECT date_start FROM tariff";
            cb = ComboDate;
            con.FillDataComboBoxses(command, cb);
        }

        private void ComboDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Connect.selectDate = ComboDate.SelectedItem.ToString();
            ViewApartment();
        }
    }
}

