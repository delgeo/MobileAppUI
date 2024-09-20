using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "Roboto Bold")]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "Roboto Light")]
[assembly: ExportFont("Roboto-Medium.ttf", Alias = "Roboto Medium")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Roboto Regular")]

namespace MobileAppUI
{
    public partial class App : Application
    {
        public Color BarBackgroundColor { get; private set; }
        public Color BarTextColor { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

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