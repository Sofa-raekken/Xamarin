using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SofaAppen.ViewModels;

namespace SofaAppen.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedbackPage : ContentPage
    {
        public FeedbackPage()
        {
            InitializeComponent();
            this.BindingContext = new FeedbackViewModel();
            this.Title = "Feedback";

            var categoryList = new List<string>();
            categoryList.Add("a");
            categoryList.Add("b");



            var ratingList = new List<string>();
            ratingList.Add("1");
            ratingList.Add("2");
            ratingList.Add("3");
            ratingList.Add("4");
            ratingList.Add("5");

            //categoryPicker.ItemsSource = categoryList;
            ratingPicker.ItemsSource = ratingList;
            selectedRating.SetBinding(Label.TextProperty, new Binding("SelectedItem", source: ratingPicker));
        }
    }
}