using Microsoft.Win32;
using mvideo.Components;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mvideo.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddandReg.xaml
    /// </summary>
    public partial class AddandReg : Page
    {
        private Product prod;
        public AddandReg(Product _product)
        {
            prod = _product;
            InitializeComponent();
            DataContext = prod;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (prod.Id== 0)
            {
                App.db.Product.Add(prod);
            }
            App.db.Product.AddOrUpdate(prod);
            App.db.SaveChanges();
            NavigationClass.NextPage(new PageCompanent(new Pages.Catalog(), " Список Admins"));

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "(*.png,*.jpeg,*.jpg)| *.png| *.jpeg| *.jpg "
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                prod.MainImage = File.ReadAllBytes(openFileDialog.FileName);
                img.Source = new BitmapImage(new Uri(openFileDialog.FileName));
            }

        }
    }
}
