using SofaAppen.Models;
using SofaAppen.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SofaAppen.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        private List<Event> _events;

        public List<Event> Events { get { return _events; } set { _events = value; OnPropertyChanged(); } }

        private Event _event;

        public Event Event { get { return _event; } set { _event = value; OnPropertyChanged(); } }

        public Command SelectedEvent { get; set; }

        private bool _isError;
        public bool IsError { get { return _isError;  } set { _isError = value; OnPropertyChanged(); } }
        public IApiClient Api { get; }


        public EventsViewModel()
        {
            Api = DependencyService.Get<IApiClient>();

            _events = new List<Event>();
            IsError = false;
            Title = "Begivenheder";
            SelectedEvent = new Command(async () => { await NavigateToDetailPage(); });
            Task.Run(async () => { await InitAsync(); IsBusy = false; });
        }

        private async Task InitAsync()
        {
           await GetEvents();
        }

        public async Task NavigateToDetailPage()
        {
            await Shell.Current.GoToAsync($"events/details?eventId={Event.IdEvent}");
        }

        private async Task GetEvents()
        {
            try
            {
                IsBusy = true;
                Events = await Api.GetEvents();

            }
            catch (Exception e)
            {

                IsError = true;
            }

        }
    }
}
