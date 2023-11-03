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

            StringBuilder error = new StringBuilder();



            if (prod.Id == 0 && App.db.Product.Any(x => x.Title == prod.Title))
            {
                error.AppendLine("Такая услуга уже имеется");

            }
            else
            {


                App.db.Product.Add(prod);

                NavigationClass.NextPage(new PageCompanent(new Pages.Catalog(), "Список админ"));
            }
            if (int.Parse(discountTb.Text) <= 0 | int.Parse(discountTb.Text) > 100)
            {
                error.AppendLine("Некоректные данные ");
            }

            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString());
            }
            else
            {
                try
                {
                    App.db.SaveChanges();
                    MessageBox.Show("save!");
                    NavigationClass.companents.Clear();
                    NavigationClass.NextPage(new PageCompanent(new Pages.Catalog(), "Список адимн"));
                }
                catch {

                    
                    MessageBox.Show("error!");
                    NavigationClass.NextPage(new PageCompanent(new Pages.Catalog(), "Список адимн"));
                }

                }
        }
            private void chenaTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
            {
                if (!(char.IsDigit(e.Text[0])))
                {
                    e.Handled = true;

                }

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

