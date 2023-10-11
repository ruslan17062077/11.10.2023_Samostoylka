﻿using mvideo.Components;
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
                catalWP.Children.Add(new UserControl1(new Image(), prods.Title.ToString(), Oct(prods.Id), prods.Cost));
            }
        }

        private static decimal Oct(int id)
        {
            try
                {
                int itog = 0;
                int count = 0;

                var otchov = App.db.Feedback.ToList();
                foreach (var ocns in otchov)
                {
                    if (ocns.ProductId == id)
                    {
                        itog = ocns.Evaluation;
                        count++;

                    }


                }

                return (itog / count);
            }
            catch {
                return 0;
            }
        }

    }
}
