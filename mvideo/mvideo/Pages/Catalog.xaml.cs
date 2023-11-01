using mvideo.Components;
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

namespace mvideo.Pages
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page

    {
      
        public Catalog()
        {
            InitializeComponent();
            

            Refresh();
        }

        private void addProd_Click(object sender, RoutedEventArgs e)
        {
            mvideo.Components.NavigationClass.NextPage(new PageCompanent(new AddandReg(new Product()), "Добавление товара"));
        }
        private void Refresh()
        {
            var prod = App.db.Product.ToList();
            IEnumerable<Product> services = App.db.Product.ToList();
            int servisCountStar = services.Count();


            catalWP.Children.Clear();
            int sercountend = services.Count();
            foreach (var prods in services)
            {
                catalWP.Children.Add(new UserControl1(prods));
            }
            if (App.admins == false)
            {
                addProd.Visibility = Visibility.Hidden;
            }
            else
            {
                addProd.Visibility = Visibility.Visible;
            }

            coltb.Text = $"{sercountend} из {servisCountStar}";
        }







        

    

        private void sortcb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void diskountcb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Refresh();
        }

        private void SeartCBg_TextChanged(object sender, TextChangedEventArgs e)
        {
            Refresh();
        }
    }
}
