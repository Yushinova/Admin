using ClassLib;
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
    public partial class MainWindow : Window
    {
        public List<ClassLib.Dish_bll> dishes = new List<ClassLib.Dish_bll>()
            {
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
                new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1}
            };
        public MainWindow()
        {
            InitializeComponent();
            DishesWindow window = new DishesWindow(this);
            
           // window.DataContext = dishes;
            window.Show();
        }
        public void AddDish(Dish_bll dish)
        {
            dishes.Add(dish);
        }
    }
}