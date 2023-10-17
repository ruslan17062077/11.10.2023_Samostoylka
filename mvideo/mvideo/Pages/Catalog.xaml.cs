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
            var prod = App.db.Product.ToList();

            foreach (var prods in prod )
            {
                catalWP.Children.Add(new UserControl1(new Image(), prods.Title.ToString(), prods.AverageRating, prods.CountFeedback.Item1 ,(double)prods.Cost, (double)prods.Discount, prods.CostVisibilitr, prods.CountFeedback.Item2));
            }
            if(App.admins == false) { 
                addProd.Visibility = Visibility.Hidden;
            }
            else
            {
                addProd.Visibility= Visibility.Visible;
            }
        }

        private void addProd_Click(object sender, RoutedEventArgs e)
        {
            AddProds taskWindow = new AddProds();
            taskWindow.Show();
        }
    }
}
