using ClassLib;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public delegate void main_delegate();
    public partial class MainWindow : Window
    {
        public Admin_Cafe_bll admin = new Admin_Cafe_bll()
        {
            Id_admin = 1,
            Address = "hhh",
            Login = "ff",
            Password = "hjj",
            Name_cafe = "Cafe",
            Phone = "8-800-00-600",
            Image_byte = File.ReadAllBytes(@"C:\Users\User\Desktop\проект\Admin\лого.jpg"),
            Image_name = "лого.jpg"
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            //RegistrationWindow registrationWindow = new RegistrationWindow(this);
            //registrationWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            //registrationWindow.ShowDialog();
            OrdersWindow ordersWindow = new OrdersWindow(admin);
            ordersWindow.Show();

        }

        private void AutButton_Click(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorizationWindow = new AuthorizationWindow(this);
            authorizationWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            authorizationWindow.ShowDialog();
        }

    }
}