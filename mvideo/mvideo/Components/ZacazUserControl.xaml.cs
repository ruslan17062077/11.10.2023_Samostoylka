using System;
using System.Collections;
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
using mvideo.Components;

namespace mvideo.Components
{
    /// <summary>
    /// Логика взаимодействия для ZacazUserControl.xaml
    /// </summary>
    public partial class ZacazUserControl : UserControl
    {
        private List lists;
       
        public ZacazUserControl(List _lists)
        {
            InitializeComponent();
             
            Update();
            lists = _lists;
            
            
                img.Source = GetImageSours(lists.Product.MainImage);
                name.Text = lists.Product.Title;
                chena.Text = lists.Product.Cost.ToString();
                coli.Text = lists.Count.ToString();
                itog.Text = (Convert.ToInt32(lists.Product.Cost) * Convert.ToInt32(lists.Count)).ToString();
            

        }
        public void Update() {
            
            }
        private BitmapImage GetImageSours(byte[] byteImage)
        {
            if(byteImage != null)
            {
                MemoryStream byteStream = new MemoryStream(byteImage);
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = byteStream;
                bitmapImage.EndInit();
                return bitmapImage;
            }
            else 
            {
                return new BitmapImage();
            }
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            App.db.List.Remove(lists);
            App.db.SaveChanges();
            App.zacazPage.RefreshZak();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

            App.db.List.Where(x => x.ID == lists.ID).ToList().ForEach(x => x.Count = x.Count + 1);
            App.db.SaveChanges();
            App.zacazPage.RefreshZak();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (lists.Count > 1)
            {
                App.db.List.Where(x => x.ID == lists.ID).ToList().ForEach(x => x.Count = x.Count - 1);
                App.db.SaveChanges();
                App.zacazPage.RefreshZak();
            }
            else if(lists.Count == 1)
            {
                App.db.List.Remove(lists);
                App.db.SaveChanges();
                App.zacazPage.RefreshZak();
            }
        }
    }
}
