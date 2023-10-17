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
        public UserControl1(Image _photo, string _name, double _otc, int count, double _chena, double _discount , Visibility visibilityskid, Visibility visibilityFed )
        {           
            InitializeComponent();






                photo = _photo;
                NameTB.Text = _name;
                othovTb.Text = $"⭐{_otc.ToString("F2")}  { count } отзыв";
                chenaSkidTB.Text = $"{_chena.ToString("f2")}";
                chenaTB.Text = $" {(_chena - (_chena*_discount/100) ):f2}";
                chenaSkidTB.Visibility = visibilityskid;
                othovTb.Visibility = visibilityFed;
                

            


        }
    }
}
