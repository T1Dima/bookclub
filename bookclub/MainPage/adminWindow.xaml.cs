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

namespace bookclub.MainPage
{
    /// <summary>
    /// Логика взаимодействия для adminWindow.xaml
    /// </summary>
    public partial class adminWindow : Window
    {
        private List<Product> products;
        public adminWindow()
        {
            InitializeComponent();
            LoadProducts();
        }

        private void LoadProducts()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Name = "Книга 1", Price = 500, Stock = 10 },
                new Product { Id = 2, Name = "Книга 2", Price = 700, Stock = 5 },
                new Product { Id = 3, Name = "Книга 3", Price = 1200, Stock = 8 }
            };

            lvProducts.ItemsSource = products;
        }
        private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductPage addProductPage = new AddProductPage();
            

            // Если новый товар добавлен, обновитm список
            LoadProducts();
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnManageOrder_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }
}
