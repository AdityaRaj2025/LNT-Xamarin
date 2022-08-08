using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using LNT.Droid;
using LNT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Platform.Android;

[assembly: Xamarin.Forms.ExportRenderer(typeof(MyWebView), typeof(MyWebViewRenderer))]
namespace LNT.Droid
{
    public class MyWebViewRenderer : WebViewRenderer
    {
        public MyWebViewRenderer(Context context) : base(context) { }
        static MyWebView _xwebView = null;
        WebView _webView;
       
        class ExtendedWebViewClient : Android.Webkit.WebViewClient
        {
             public override bool ShouldOverrideUrlLoading(WebView view, string url)
            {
                var tel = "tel:";
                if (url != null)
                {
                    if (url.StartsWith(tel))
                    {

                        var uri = Android.Net.Uri.Parse(url);
                        var intent = new Intent(Intent.ActionView, uri);
                        intent.SetFlags(ActivityFlags.NewTask);
                        return true;
                    }
                    
                }
                return false;
            }
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);
            _xwebView = e.NewElement as MyWebView;
            _webView = Control;

            if (e.OldElement == null)
            {
                _webView.SetWebViewClient(new ExtendedWebViewClient());
              
            }
        }

    }
}
