using System;
using System.Collections.Generic;
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
using System.Data;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq.Expressions;



namespace CommunalPayments
{
    /// <summary>
    /// Логика взаимодействия для TariffCalculateWindow.xaml
    /// </summary>
    public partial class MainView : Window
        
    {
        Connect con = new Connect();
        DataGrid dg = new DataGrid();
        Visibility vis = new Visibility();

        public MainView() 
        {
            InitializeComponent();
            dg = dataGridDirectory;
        }

        private void ButtonActive(Visibility vis)
        {
            addTariffButton.Visibility = vis;
            textBoxNameTariff.Visibility = vis;
            textBoxPayVal.Visibility = vis;
            datePickerTariffStart.Visibility = vis;
            labelDate.Visibility = vis;
            labelNameTariff.Visibility = vis;
            labelPay.Visibility = vis;
        }

        string selTariff;
        private void Menu_Tariff_Click(object sender, RoutedEventArgs e)
        {
            selTariff = "SELECT * FROM tariff";
            string tabTariff = "tariff";
            con.ActionWithDB(selTariff, tabTariff, dg);
            ButtonActive(vis = Visibility.Visible);

        }

        private void Menu_Houses_Click(object sender, RoutedEventArgs e)
        {
            string selHouses = "SELECT type_house, count_apartments, street_name, number_house FROM houses, streets WHERE houses.street = streets.id_streets";
            string tabHouses = "houses";
            dg = dataGridDirectory;
            con.ActionWithDB(selHouses, tabHouses, dg);
            ButtonActive(vis = Visibility.Collapsed);
        }

        private void Menu_Apartments_Click(object sender, RoutedEventArgs e)
        {
            string selApartments = "SELECT id_apartment, street_name, number_house, number_apartment, area FROM apartment, houses, streets WHERE streets.id_streets = houses.street AND apartment.house = houses.id_house";
            string tabApartments = "apartment";
            con.ActionWithDB(selApartments, tabApartments, dg);
            ButtonActive(vis = Visibility.Collapsed);
        }

        private void Menu_Streets_Click(object sender, RoutedEventArgs e)
        {
            string selStreets = "SELECT * FROM streets";
            string tabStreets = "streets";
            con.ActionWithDB(selStreets, tabStreets, dg);
            ButtonActive(vis = Visibility.Collapsed);
        }

        private void Menu_Result_Click(object sender, RoutedEventArgs e)
        {
            Сalculation win = new Сalculation();
            win.Show();
            string selApartments = "SELECT res_price, street_name, number_house, number_apartment, area, date FROM result, apartment, houses, streets WHERE result.apartment = apartment.id_apartment AND streets.id_streets = houses.street AND apartment.house = houses.id_house";
            string tabApartments = "result";
            con.ActionWithDB(selApartments, tabApartments, dg);
            ButtonActive(vis = Visibility.Collapsed);
        }

        private void addTariffButton_Click(object sender, RoutedEventArgs e)
        {
            string tariff = textBoxNameTariff.Text;
            string pay = textBoxPayVal.Text;
            string date = datePickerTariffStart.SelectedDate.Value.Date.ToShortDateString();
            string inc = "INSERT INTO tariff(name_tariff, price, date_start) VALUES('"+ tariff +"', '"+ pay +"', '"+ date +"')";
            con.ActionWithDB(inc, "tariff", dg);
            con.ActionWithDB(selTariff, "tariff", dg);

        }

        private void Charges_Click(object sender, RoutedEventArgs e)
        {
            Charges charges = new Charges();
            charges.Show();
        }

        
    }
}
