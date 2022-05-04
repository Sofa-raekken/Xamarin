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
    public partial class AnimalDetailPage : ContentPage
    {
        public AnimalDetailPage()
        {
            InitializeComponent();
            this.Title = "Information om dyret";
            this.BindingContext = new AnimalDetailViewModel();
        }
    }
}