﻿using mvideo.Components;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace mvideo
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HS db = new HS();
        public static bool admins = false;
        public static MainWindow mainWindow;
        public static Pages.AddandReg prodPage;
        public static Pages.Zacaz zacazPage;
        
    }
}
