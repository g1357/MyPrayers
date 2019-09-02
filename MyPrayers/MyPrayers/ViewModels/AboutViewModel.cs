using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace MyPrayers.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenAboutPage = new Command(() => ShowAboutPage()); ;
            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }

        public ICommand OpenAboutPage { get; }

        void ShowAboutPage()
        {
            var browser = new WebView();
            var htmlSource = new HtmlWebViewSource();
            htmlSource.Html = @"<html><body>
                <h1>Xamarin.Forms</h1>
                <p>Welcome to WebView.</p>
                </body></html>";
            browser.Source = htmlSource;
        }
    }
}