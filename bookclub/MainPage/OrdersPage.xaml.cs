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
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        public OrdersPage()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            
            List<Order> orders = new List<Order>
            {
                new Order { OrderId = 1, Customer = "Иван Иванов", Total = 1500 },
                new Order { OrderId = 2, Customer = "Петр Петров", Total = 2000 }
            };

            lvOrders.ItemsSource = orders;
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Order selectedOrder = lvOrders.SelectedItem as Order; // редактирование выбраного заказа
            if (selectedOrder != null)
            {
                MessageBox.Show($"Редактируем заказ {selectedOrder.OrderId}");
            }
            else
            {
                MessageBox.Show("Выберите заказ для редактирования.");
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Order selectedOrder = lvOrders.SelectedItem as Order; //  удаление выдбаронного заказа 
            if (selectedOrder != null)
            {
                MessageBox.Show($"Удаляем заказ {selectedOrder.OrderId}");
            }
            else
            {
                MessageBox.Show("Выберите заказ для удаления.");
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
    public class Order
    {
        public int OrderId { get; set; }
        public string Customer { get; set; }
        public double Total { get; set; }
    }
}

