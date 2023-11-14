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
using System.Windows.Navigation;
using System.Windows.Shapes;
using mvideo.Components;

namespace mvideo.Components
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private Product product;
        public UserControl1(Product _prod )
        {   
            product = _prod;
            InitializeComponent();
            if(App.admins == false)
            {
                Edit.Visibility = Visibility.Collapsed;
                Delite.Visibility = Visibility.Collapsed; 
            }
            else { Edit.Visibility = Visibility.Visible;
            Delite.Visibility = Visibility.Visible;}





                photo.Source = GetImageSours(_prod.MainImage);
                NameTB.Text = _prod.Title;
                othovTb.Text = $"⭐{_prod.AverageRating.ToString("F2")}  { _prod.CountFeedback.Item1 } отзыв";
                chenaSkidTB.Text = $"{_prod.Cost.ToString("f2")}";
                chenaTB.Text = $" {_prod.TotalCost:f2}";
                chenaSkidTB.Visibility = _prod.CostVisibilitr;
                othovTb.Visibility = _prod.CountFeedback.Item2;
                MainBorder.BorderBrush = _prod.ColorBrush;






        }
        private BitmapImage GetImageSours(byte[] byteImage)
        {
            try
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = byteStream;
                bitmapImage.EndInit();
                return bitmapImage;
            }
            catch
            {
                return null;
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            NavigationClass.NextPage(new PageCompanent(new Pages.AddandReg(product), $" Редактирование товара/{product.Title}"));
        }

        private void Delite_Click(object sender, RoutedEventArgs e)
        {
            if (product.Feedbacks.Count > 0)
            {
                MessageBox.Show("У него есть отзовы нельзя удалить ");
            }
            else
            {


                App.db.Products.Remove(product);
                App.db.SaveChanges();
                NavigationClass.companents.Clear();
                NavigationClass.NextPage(new PageCompanent(new Pages.Catalog(), "Список Admin"));
            }
            
        }

        private void kupBtn_Click(object sender, RoutedEventArgs e)
        {
            App.db.Lists.Add(new List
            {
                Id_prod = product.Id,
                col = 1
            }) ;
            App.db.SaveChanges();
                
        }
    }
}
