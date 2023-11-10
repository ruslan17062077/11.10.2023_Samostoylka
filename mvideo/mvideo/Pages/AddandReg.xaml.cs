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
            App.prodPage = this;
            

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder error = new StringBuilder();


            try
            {
                if (prod.Id == 0 && App.db.Products.Any(x => x.Title == prod.Title))
                {
                    error.AppendLine("Такая услуга уже имеется");

                }
                else if (int.Parse(discountTb.Text) <= 0 | int.Parse(discountTb.Text) > 100)
                {


                    error.AppendLine("Некоректные данные ");


                }
                else
                {
                 
                    
                        App.db.Products.AddOrUpdate(prod);
                    

                        

                    NavigationClass.NextPage(new PageCompanent(new Pages.Catalog(), "Список админ"));
                }
            }
            catch
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
        public void RefreshPhoto()
        {
            PhotoWp.Children.Clear();
            foreach (var photo in App.db.ProductPhotoes)
            {
                PhotoWp.Children.Add(new PhotoUserControl(photo));
            }
            BitmapImage bitmapImage = new BitmapImage();
            MemoryStream byteStream = new MemoryStream(prod.MainImage);
            bitmapImage.BeginInit();
            bitmapImage.StreamSource = byteStream;
            bitmapImage.EndInit();
            img.Source = bitmapImage;
        }

        private void AddImageBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpg|*.jpg|*.jpeg|*.jpeg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
                App.db.ProductPhotoes.Add(new ProductPhoto
                {
                    id_prod = prod.Id,
                    PhotoByte = File.ReadAllBytes(openFile.FileName)

                });
            RefreshPhoto();
            App.db.SaveChanges();
        }
    }
}

