using SofaAppen.ViewModels;
using SofaAppen.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SofaAppen
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute(nameof(AnimalsPage), typeof(AnimalsPage));
            Routing.RegisterRoute("animals/details", typeof(AnimalDetailPage));

        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
