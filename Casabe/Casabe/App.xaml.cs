﻿using Casabe.VistaModelo;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Casabe.Vista;
using Casabe.Vista.MenuOpciones;

namespace Casabe
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Empezar());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
