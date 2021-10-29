using System;
using Xamarin.Forms;

namespace ReportAsapp.View.Configuration
{
    public static class NavigationConfig
    {
        public static void configure(ContentPage page)
        {
            if (Device.RuntimePlatform == Device.Android)
            {
                NavigationPage.SetHasNavigationBar(page, false);
            }
        }
    }
}
