using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using SofaAppen.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SofaAppen.ViewModels
{
    public class FeedbackViewModel : BaseViewModel
    {
        private List<Category> _categories;
        
        public List<Category> Categories { get { return _categories; } set { _categories = value; OnPropertyChanged(); } }

        public Category SelectedCategory { get; set; }
        

        private bool _isError;
        public bool IsError { get { return _isError; } set { _isError = value; OnPropertyChanged(); } }

        public FeedbackViewModel()
        {
            _categories = new List<Category>();
            IsError = false;
            Title = "Feedback";
            Task.Run(async () => { await InitAsync(); IsBusy = false; });
        }

        private async Task InitAsync()
        {
            await GetCategories();
        }

        private async Task GetCategories()
        {
            try
            {
                IsBusy = true;
                Categories = await Api.GetCategories();

            }
            catch (Exception e)
            {

                IsError = true;
            }

        }
    }
}
