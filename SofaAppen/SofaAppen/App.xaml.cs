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

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell(); // This is from the original code and may be needed to be changed back to this when the app is finished
            //MainPage = new Views.HomePage();
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
