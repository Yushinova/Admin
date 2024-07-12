using Admin.User_control;
using ClassLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public delegate void dish_delegate(Dish_bll dish);
    /// <summary>
    /// Логика взаимодействия для DishesWindow.xaml
    /// </summary>
    public partial class DishesWindow : Window
    {
        //делать запрос, получать все блюда и засовывать в обсервал иначе не видно
        public ObservableCollection<ClassLib.Dish_bll> dishes = new ObservableCollection<ClassLib.Dish_bll>()
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
       public Dish_bll dish = new Dish_bll();
        public DishesWindow()
        {

            InitializeComponent();
            DishesList.ItemsSource = dishes;
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)//добавляется обсервал нужно
        {
            AddDishWindow dishWindow = new AddDishWindow(this);
            dishWindow.Owner = this;
            dishWindow.Title = "Новое блюдо";
            dishWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dishWindow.Show();
          
        }
        public void AddDish(Dish_bll dish)//тут
        {
            dishes.Add(dish);
        }
        public void RedDish(Dish_bll dish)
        {
            dishes[dish.Id_dish] = dish;
        }
        private void RedButton_Click(object sender, RoutedEventArgs e)//надо подумать как сделать по другому
        {
            int ind = int.Parse((((sender as Button).Parent as StackPanel).Children[0] as DishPanel).DishId.Text);
            dish = dishes[ind];
            RedDishWindow dishWindow = new RedDishWindow(this);
            dishWindow.Owner = this;
            dishWindow.Title = "Редактор";
            dishWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            dishWindow.Show();
        }
    }
}
