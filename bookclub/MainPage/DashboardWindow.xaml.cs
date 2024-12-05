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

namespace bookclub.MainPage
{
    /// <summary>
    /// Логика взаимодействия для DashboardWindow.xaml
    /// </summary>
    public partial class DashboardWindow : Window
    {

        private readonly string userRole;
        public DashboardWindow(string role)
        {
            InitializeComponent();
            userRole = role;
            SetupInterface();
        }

        private void SetupInterface()
        {
            // вход интерфейс в зависимости от роли
            if (userRole == "Admin")
            {
                BtnViewOrders.Visibility = Visibility.Visible;
                BtnAddProduct.Visibility = Visibility.Visible;
            }
            else if (userRole == "Manager")
            {
                BtnViewOrders.Visibility = Visibility.Visible;
            }
        }

        private void BtnViewOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OrdersPage());
        }

        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new AddProductPage());
        }

        private void BtnViewProducts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ProductsPage());
        }

        private void BtnViewCart_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CartPage());
        }
    }
}
