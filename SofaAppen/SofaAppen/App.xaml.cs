using SofaAppen.Services;
using SofaAppen.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SofaAppen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<ApiClient>();
            DependencyService.Register<QrScanningService>();

            MainPage = new AppShell();
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
