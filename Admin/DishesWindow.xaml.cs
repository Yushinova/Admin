using Admin.User_control;
using ClassLib;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для DishesWindow.xaml
    /// </summary>
    public partial class DishesWindow : Window
    {
        //public List<ClassLib.Dish_bll> dishes = new List<ClassLib.Dish_bll>()
        //     {
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1},
        //         new ClassLib.Dish_bll { Name_dish="Бургер", Price=199.55, Description="250г. Булка, котлета, сыр, соус", Image_byte=File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name="бургер.png", isActual=1}
        //     };
        public Dish_bll dish = new Dish_bll();
        public MainWindow wi = new MainWindow();
        public DishesWindow(MainWindow window)
        {
            
        InitializeComponent();
            DishesList.ItemsSource = window.dishes;
            wi=window;


        // XZ.Text = dishes.Count.ToString();
    }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
            dish = new ClassLib.Dish_bll { Name_dish = "Бургер2", Price = 199.55, Description = "250г. Булка, котлета, сыр, соус", Image_byte = File.ReadAllBytes(@"C:\Users\User\Desktop\проект\me\бургер.png"), Image_name = "бургер.png", isActual = 1 };
            wi.AddDish(dish);
        }
        //public void AddDish(List<Dish_bll> dishes)
        //{
        //    dishes.Add(dish);
        //}
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
          
        }
    }
}
