using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LNT
{
    public partial class MainPage : ContentPage
    {
       
         string url = "https://62f096c2a304d71637762981--sunny-bavarois-4f56b7.netlify.app/";
        MyWebView browser = new MyWebView();
        public MainPage()
        {
            InitializeComponent();
            browser.Source = url;
            webview.Children.Add(browser);
        }
         protected override void OnAppearing()
        {
            browser.HeightRequest = (stacklayout.Height - stack.Height);
            base.OnAppearing();
        }
    }
}
