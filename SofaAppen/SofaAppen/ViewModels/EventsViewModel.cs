using SofaAppen.Models;
using SofaAppen.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SofaAppen.ViewModels
{
    public class EventsViewModel : BaseViewModel
    {
        private List<Event> _events;

        public List<Event> Events { get { return _events; } set { _events = value; OnPropertyChanged(); } }

        public Event SelectedEvent { get; set; }

        private bool _isError;
        public bool IsError { get { return _isError;  } set { _isError = value; OnPropertyChanged(); } }

        public EventsViewModel()
        {

            _events = new List<Event>();
            IsError = false;
            Title = "Begivenheder";
            Task.Run(async () => { await InitAsync(); });
        }

        private async Task InitAsync()
        {
           await GetEvents();
        }

        private async Task GetEvents()
        {
            try
            {
                Events = await Api.GetEvents();

            }
            catch (Exception e)
            {

                IsError = true;
            }

        }
    }
}
