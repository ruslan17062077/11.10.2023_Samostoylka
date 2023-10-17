using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace mvideo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var path = @"C:\Users\222108\Desktop\Задание магазин техники\";
            //foreach (var item in App.db.Product.ToArray())
            //{
            //    var fullPath = path + item.Image.Trim();
            //    var imageByte = File.ReadAllBytes(fullPath);
            //    item.MainImage = imageByte;
            //}
            //App.db.SaveChanges();
            frams.Navigate(new Pages.Catalog());
            if(App.admins = false)
            { 
                vhodadmin.Visibility = Visibility.Collapsed;
                passwordadm.Visibility = Visibility.Collapsed;
            }
            else
            {
                endadmin.Visibility = Visibility.Collapsed;
            }
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void vhodadmin_Click(object sender, RoutedEventArgs e)
        {
            if(passwordadm.Password == "0000")
            {
                App.admins = true;
                vhodadmin.Visibility = Visibility.Collapsed;
                passwordadm.Visibility= Visibility.Collapsed;
                endadmin.Visibility= Visibility.Visible;
                InitializeComponent();
                frams.Navigate(new Pages.Catalog());
            }

        }

        private void endadmin_Click(object sender, RoutedEventArgs e)
        {
            App.admins= false;
            vhodadmin.Visibility = Visibility.Visible;
            passwordadm.Visibility = Visibility.Visible;
            endadmin.Visibility = Visibility.Collapsed;
            InitializeComponent();
            frams.Navigate(new Pages.Catalog());
        }
    }
}
