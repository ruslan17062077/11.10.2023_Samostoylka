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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Image _photo, string _name, decimal _otc, decimal _chena )
        {
            InitializeComponent();
            if (_otc == 0 || _otc == 1)
            {
                photo = _photo;
                NameTB.Text = _name;
                othovTb.Visibility = Visibility.Hidden;
                chenaTB.Text = $"{_chena}";
            }
            else
            {
                photo = _photo;
                NameTB.Text = _name;
                othovTb.Text = _otc.ToString();
                chenaTB.Text = $"{_chena}   {(_chena / _otc):0}";
            }


        }
    }
}
