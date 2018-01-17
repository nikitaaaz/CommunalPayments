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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CommunalPayments
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
           
        }
        private void Connect_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                if (textBoxLogin.Text == null || textBoxPassword.Text == null)
                {
                    MessageBox.Show("Поля для ввода логина или пароля пусты. Введите корректные данные");
                }

                if (login == "admin" && password == "admin123")
                {
                    MainView tariffWin = new MainView();
                    tariffWin.Show();
                    
                }
                else
                {
                    MessageBox.Show("Не верный логин или пароль, попробуйте ещё раз или закройте программу");
                    textBoxLogin.Clear();
                    textBoxPassword.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так, повторите ещё раз");
            }
            this.Close();
        }
        
    }
}
