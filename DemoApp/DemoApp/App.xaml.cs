using System;
using DemoApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
            //MainPage = new NotificationPage();
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
