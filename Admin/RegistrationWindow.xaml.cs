using ClassLib;
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

namespace Admin
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public Admin_Cafe_bll admin = new Admin_Cafe_bll();
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void LogoButton_Click(object sender, RoutedEventArgs e)
        {
            //загрузка логотипа
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            //отпарвка запроса на регистрацию, если все прошло хорошо,
            //вызываем главное окно с заказами
        }
    }
}
