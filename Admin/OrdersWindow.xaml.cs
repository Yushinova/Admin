using Admin.Models;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
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

namespace Admin
{
    /// <summary>
    /// получаем все заказы и юзеров из базы данных
    /// маппируем все заказы в наш класс, состоящий из заказов и юзеров
    /// при изменении статуса заказа берем его из полученного листа заказов из базы данных, отправляем его на апдейт
    /// переустанавливаем все заказы юзеров и юзеров
    /// нужно установить переустановку заказов и юзеров 1 раз в минуту, 
    /// </summary>
    public delegate void admin_delegate(Admin_Cafe_bll admin);
    public partial class OrdersWindow : Window
    {
        public Admin_Cafe_bll admin_;
        public List<Order_bll> orders_bll = new List<Order_bll>();//запрос
        public List<User_bll> users = new List<User_bll>();//запрос
        public ObservableCollection<Wpf_order> wpf_orders = new ObservableCollection<Wpf_order>();
        public OrdersWindow(Admin_Cafe_bll admin)
        {
            admin_ = admin;
            InitializeComponent();
            AdminPanel.DataContext = admin_;
            
        }

        private void DishButton_Click(object sender, RoutedEventArgs e)
        {
            DishesWindow dishesWindow = new DishesWindow();
            dishesWindow.ShowDialog();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            RedAdminWindow redAdminWindow = new RedAdminWindow(this);
            redAdminWindow.ShowDialog();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            if(MenuPanel.Visibility==Visibility.Hidden) MenuPanel.Visibility=Visibility.Visible;
            else MenuPanel.Visibility = Visibility.Hidden;
        }
        
        public void ChageAdmin(Admin_Cafe_bll admin_new)//update admin
        {
            admin_ = admin_new;
            AdminPanel.DataContext = admin_;
        }
    }
}
