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
            if (sortcb.SelectedIndex != 0)
            {
                if (sortcb.SelectedIndex == 1)
                {
                    services = services.OrderBy(x => x.TotalCost);

                }
                else
                    services = services.OrderByDescending(x => x.TotalCost);
            }
            if (diskountcb.SelectedIndex != 0)
            {
                if (diskountcb.SelectedIndex == 1)
                {
                    services = services.Where(x => x.Discount < 5 | x.Discount == null);
                }
                else if (diskountcb.SelectedIndex == 2)
                {
                    services = services.Where(x => (int)x.Discount > 5 & (int)x.Discount < 15);
                }
                else if (diskountcb.SelectedIndex == 3)
                {
                    services = services.Where(x => (int)x.Discount > 15 & (int)x.Discount < 30);
                }
                else if (diskountcb.SelectedIndex == 4)
                {
                    services = services.Where(x => (int)x.Discount > 30 & (int)x.Discount < 70);
                }
                else if (diskountcb.SelectedIndex == 5)
                {
                    services = services.Where(x => (int)x.Discount > 70 & (int)x.Discount < 100);
                }
            }
            if (SeartCBg.Text != null)
            {
                services = services.Where(x => x.Title.ToLower().Contains(SeartCBg.Text.ToLower()) ||
                x.Description.ToLower().Contains(SeartCBg.Text.ToLower())
                );
            }

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
