
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;

namespace CommunalPayments
{
    class Connect
    {
       
        public void ActionWithDB(string Command, string table, DataGrid dg)
        {
            try
            {
                using (var conn = new SQLiteConnection(@"Data Source=referenceBook.db;Pooling=true;FailIfMissing=false;Version=3"))
                using (var comm = conn.CreateCommand())
                {
                    {
                        comm.CommandText = Command;
                        comm.CommandType = CommandType.Text;

                        conn.Open();
                        SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(comm);
                        DataSet ds = new DataSet();
                        dataAdapter.Fill(ds, table);
                        if (Command.Contains("SELECT") == true)
                        {
                            dg.ItemsSource = ds.Tables[table].DefaultView;
                        }
                        conn.Close();
                    }
                }
            }
            catch(SQLiteException)
            {
                MessageBox.Show("Данные неверны либо повторяются");
            }
        }

        Connect connect { get; set; }
        public static double resPay { get; set; }
        public static double summTar { get; set; }
        public static double result { get; set; }
        public static string dateStart { get; set; }
        public static int tariff_id { get; set; }
        public static int apartment_id { get; set; }
        public static string selectDate { get; set; }
        public static string SelectDateStart { get; set; }
        public static string SelectDateStop { get; set; }
        public static int SelectApartmentNum { get; set; }
        public static int SelectHouseNum { get; set; }

        public void FillDataComboBoxses(string command, ComboBox comboBox)
        {
            using (var conn = new SQLiteConnection(@"Data Source=referenceBook.db;Pooling=true;FailIfMissing=false;Version=3"))
            using (var comm = conn.CreateCommand())
            {
                {
                    comm.CommandText = command;
                    comm.CommandType = CommandType.Text;

                    conn.Open();
                    using (SQLiteDataReader reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBox.Items.Add(reader.GetValue(0).ToString().TrimEnd());
                        }

                        conn.Close();
                    }
                }
            }
        }

    }
}
