﻿using SofaAppen.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SofaAppen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EventsDetailPage : ContentPage
    {
        public EventsDetailPage()
        {
            InitializeComponent();
            this.BindingContext = new EventDetailViewModel();
            this.Title = "Event";
        }
    }
}