﻿using SecureMessengerDNet;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SecureMessengerDNet
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var login = new Login();
            var context = new Loginmodel();
            login.DataContext = context;
            login.Show();
            //var app = new Window1();
            //var context = new ViewModel();
            //app.DataContext = context;
            //app.Show();
        }                

    }


}
