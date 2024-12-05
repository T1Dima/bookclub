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

namespace bookclub.MainPage
{
    /// <summary>
    /// Логика взаимодействия для ProductsPage.xaml
    /// </summary>
    public partial class ProductsPage : Page
    {
        private readonly string userRole;
        public ProductsPage()
        {
            InitializeComponent();
            userRole = role;
            LoadProducts();
        }

        private void LoadProducts()
        {
            List<Product> products = new List<Product>
            {
                new Product { Name = "Книга 1", Price = 500 },
                new Product { Name = "Книга 2", Price = 700 }
            };

            lvProducts.ItemsSource = products; //привязка данных для списка данных 

        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}
