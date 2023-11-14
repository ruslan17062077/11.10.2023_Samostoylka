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
    /// Логика взаимодействия для ZacazUserControl.xaml
    /// </summary>
    public partial class ZacazUserControl : UserControl
    {
        private List lists;
       
        public ZacazUserControl(List _lists)
        {
            InitializeComponent();
                img.Source = GetImageSours(lists.Product.MainImage);
            
            
            lists = _lists;
            name.Text = lists.Product.Title;
            chena.Text = lists.Product.Cost .ToString();
            coli.Text = lists.col.ToString();
            itog.Text = (Convert.ToInt32( lists.Product.Cost) * Convert.ToInt32( lists.col)).ToString();

         
            

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
                return new BitmapImage();
            }
        }

    }
}
