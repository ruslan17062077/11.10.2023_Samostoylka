using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace mvideo.Components
{
    internal class NavigationClass
    {
        public static List<PageCompanent> companents = new List<PageCompanent>();
        public static MainWindow mainWindow;

        public static void NextPage(PageCompanent pageCompanent)
        {
            companents.Add(pageCompanent);
            Update(pageCompanent);
        }
        public static void BackPage()
        {
            if (companents.Count > 1)
            {
                companents.RemoveAt(companents.Count - 1);
                Update(companents[companents.Count - 1]);
            }
        }
        private static void Update(PageCompanent pageCompanent)
        {
            if (App.admins == false)
            {
                companents.Clear();
            }
            mainWindow.TitleTb.Text = pageCompanent.Title;
            mainWindow.nazad.Visibility = companents.Count() > 1 ?
                System.Windows.Visibility.Visible :
                System.Windows.Visibility.Hidden;
            mainWindow.frams.Navigate(pageCompanent.Page);
        }

    }

    class PageCompanent
    {
        public Page Page { get; set; }
        public string Title { get; set; }
        public PageCompanent(Page page, string title)
        {
            Page = page;
            Title = title;
        }
    }
}

