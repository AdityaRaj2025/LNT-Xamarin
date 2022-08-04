using Plugin.LocalNotification;
using Plugin.LocalNotification.EventArgs;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LNT
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Page1());

           
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
