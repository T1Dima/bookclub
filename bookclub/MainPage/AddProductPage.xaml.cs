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
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string productName = txtProductName.Text;
            string productPrice = txtProductPrice.Text;
            string productDescription = txtProductDescription.Text;

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(productPrice))
            {
                MessageBox.Show("Заполните все обязательные поля!");
                return;
            }

            MessageBox.Show($"Товар '{productName}' сохранен!");
        }
    

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
