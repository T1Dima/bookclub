using bookclub.MainPage;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bookclub
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnButton_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            
            if (login == "admin" && password == "admin")
            {
                // Открываем окно для администратора
                var adminWindow = new DashboardWindow("Admin");
                adminWindow.Show();
                this.Close();
            }
            else if (login == "manager" && password == "manager")
            {
                // Открываем окно для менеджера
                var managerWindow = new DashboardWindow("Manager");
                managerWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.");
            }
        
    }

        private void BtnGuestButton_Click(object sender, RoutedEventArgs e)
        {
            var guestWindow = new DashboardWindow("Guest");
            guestWindow.Show();
            this.Close();
        }
    }
}
