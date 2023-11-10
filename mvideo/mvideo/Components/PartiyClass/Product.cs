using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace mvideo.Components
{
    public partial class Product
    {
        public Visibility CostVisibilitr
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }
        public (int, Visibility) CountFeedback
        {
            get
            {
                if (Feedback.Count == 0)
                {
                    
                    return (0, Visibility.Collapsed);

                }
                else
                    return (Feedback.Count, Visibility.Visible);
            }
        }
        public double AverageRating
        {
            get
            {
                if (Feedback.Count == 0)
                    return 0;
                else
                    return Feedback.Average(x => x.Evaluation);
                
            }
        }

        public double TotalCost
        {
            get
            {
                if(Discount != 0)
                {
                    return ((double)Cost - ((double)Cost * (double)Discount / 100));
                }
                else
                {
                    return (double)Cost;
                }
            }
        }
        public Brush ColorBrush
        {
            get
            {
                if (Discount != 0)
                    return new SolidColorBrush(Colors.LightGreen);
                else
                    return new SolidColorBrush(Colors.Black);
            }
        }
    }
}
