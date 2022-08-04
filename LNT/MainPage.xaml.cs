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
       
        string url = "https://en.wikipedia.org/wiki/Wikipedia";
        public MainPage()
        {
            InitializeComponent();
            var browser = new MyWebView
            {
                Source = url,
            };
           
            webview.Children.Add(browser);
        }
    }
}
