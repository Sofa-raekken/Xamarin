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
            Routing.RegisterRoute(nameof(AnimalsPage), typeof(AnimalsPage));
            Routing.RegisterRoute("animals/details", typeof(AnimalDetailPage));
            Routing.RegisterRoute(nameof(EventsPage), typeof(AnimalsPage));
            Routing.RegisterRoute("events/details", typeof(EventDetailPage));

        }
    }
}
