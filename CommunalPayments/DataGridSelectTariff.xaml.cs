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
    public partial class dataGridSelectTariff : Window
    {

        DataGrid dg = new DataGrid();
        Connect con = new Connect();
        MainView mw = new MainView();
        public dataGridSelectTariff()
        {
            InitializeComponent();
            string selTariff = "SELECT * FROM tariff";
            string tabTariff = "tariff";
            dg = dataGridSelTariff;
            con.ActionWithDB(selTariff, tabTariff, dg);
        }
        
        private void Row_DoubleClickOnSelectTariff(object sender, MouseButtonEventArgs e)
        {
            DataRowView row = (DataRowView)dataGridSelTariff.SelectedItems[0];
            Connect.tariff_id = Convert.ToInt32(row[0]);
            Connect.summTar = Convert.ToDouble(row[2]);
            Connect.dateStart = Convert.ToString(row[4]);
            Connect.result = Connect.resPay * Connect.summTar;
            MessageBox.Show(""+ Connect.result.ToString() + " рублей по тарифу");

            InsInResult();
            this.Close();
        }

        private void InsInResult()
        {
            string selResult = "INSERT INTO result(res_price, apartment, date, tariff) VALUES('" + Connect.result + "', '"+ Connect.apartment_id +"', '"+ Connect.dateStart +"', '" + Connect.tariff_id + "')";
            string tabResult = "apartment";
            dg = mw.dataGridDirectory;
            con.ActionWithDB(selResult, tabResult, dg);
        }

       
    }
}
