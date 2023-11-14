using mvideo.Components;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Diagnostics.Contracts;
using System.Drawing;
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
    /// Логика взаимодействия для Zacaz.xaml
    /// </summary>
    public partial class Zacaz : Page
    {
        public Zacaz()
        {
            InitializeComponent();
            Refresh();
           
        }
        public void Refresh()
        {
            
            
            int servisCountStar = App.db.Lists.Count();
            var prod = App.db.Lists.ToList();


            WrapPanel.Children.Clear();
            int sercountend = App.db.Lists.Count();
            foreach (var prods in prod)
            {
                WrapPanel.Children.Add(new ZacazUserControl(prods));
            }





            colTb.Text = $"{sercountend} из {servisCountStar}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
