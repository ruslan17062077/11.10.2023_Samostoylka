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
            App.db.SaveChanges();

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
