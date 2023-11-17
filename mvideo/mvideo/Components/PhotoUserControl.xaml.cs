using System;
using System.Collections.Generic;
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

namespace mvideo.Components
{
    /// <summary>
    /// Логика взаимодействия для PhotoUserControl.xaml
    /// </summary>
    public partial class PhotoUserControl : UserControl
    {
        ProductPhoto prodPhot;
        public PhotoUserControl(ProductPhoto _prodPhoto)
        {
            InitializeComponent();
            prodPhot = _prodPhoto;
            this.DataContext = prodPhot;
        }

     

        
            
        

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            App.db.ProductPhoto.Remove(prodPhot);
            App.db.SaveChanges();
            App.prodPage.RefreshPhoto();
        }

        private void MainBtn_Click(object sender, RoutedEventArgs e)
        {
            var selPhoto = prodPhot.PhotoByte;
            prodPhot.PhotoByte = prodPhot.Product.MainImage;
            prodPhot.Product.MainImage = selPhoto;
            App.prodPage.RefreshPhoto();
            App.db.SaveChanges();

        }
    }
}
