﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsSandbox.XAML;

namespace XamarinFormsSandbox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MarkupExtensions();
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
