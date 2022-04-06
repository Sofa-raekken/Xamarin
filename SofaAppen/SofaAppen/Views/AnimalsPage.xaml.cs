using SofaAppen.ViewModels;
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
    public partial class AnimalsPage : ContentPage
    {
        public AnimalsPage()
        {
            InitializeComponent();
            this.BindingContext = new AnimalsViewModel();
            this.Title = "Dyr";
        }
    }
}