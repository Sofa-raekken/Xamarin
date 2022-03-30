using SofaAppen.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SofaAppen.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}