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
using System.ComponentModel.DataAnnotations;

namespace isjjfg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Zareg_Click(object sender, RoutedEventArgs e)
        {
            PhoneAttribute phoneAttribute = new PhoneAttribute();
            if (phoneAttribute.IsValid(Phone.Text))
            {MessageBox.Show($"{Phone.Text}");
               
            }
            else
            {
                 MessageBox.Show("zudhfiusabiufbiuasdbf");
            }

        }
    }
}
