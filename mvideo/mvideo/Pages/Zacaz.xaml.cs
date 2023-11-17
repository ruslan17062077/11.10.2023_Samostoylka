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
            App.zacazPage = this;
            InitializeComponent();
            Refresh();

        }
        public void Refresh()
        {


            int servisCountStar = App.db.List.Count();
            var prod = App.db.List.ToList();


            WrapPanel.Children.Clear();
            int sercountend = App.db.List.Count();
            foreach (var prods in prod)
            {
                WrapPanel.Children.Add(new ZacazUserControl(prods));
            }





            colTb.Text = $"{sercountend} из {servisCountStar}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        public void RefreshZak()
        {
            WrapPanel.Children.Clear();
            foreach (var prods in App.db.List.ToList())
            {
                WrapPanel.Children.Add(new ZacazUserControl(prods));
            }
        }
    }
}