using System;

using MyPrayers.Models;
using Xamarin.Forms;

namespace MyPrayers.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
            WebViewSource = new HtmlWebViewSource();
            WebViewSource.Html = @"<html><body>
                <h1>Xamarin.Forms</h1>
                <p>Welcome to WebView.</p>
                <h2>" + Title + @"</h2>
                </body></html>";

        }

        public HtmlWebViewSource WebViewSource { get; set; }

        public string strSource { get; set; }
    }
}
