using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для Oformlenie.xaml
    /// </summary>
    public partial class Oformlenie : Page
    {
        public Oformlenie()
        {
            InitializeComponent();
        }

        private void OfotmitBtn_Click(object sender, RoutedEventArgs e)
        {
            App.db.Zakaz.Add(new Components.Zakaz
            {
                Date = DateTime.Now,
                Gorod = CityTB.Text,
                Street = StreetTB.Text,
                Dom = HomeTB.Text,
                Phone = PhoneTB.Text,
                Names = NameTB.Text

            });
            App.db.SaveChanges();

            

        }
    }
}
