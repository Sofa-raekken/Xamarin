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

        public EventsViewModel()
        {
            Title = "Begivenheder";
            Task.Run(async () => { await GetEvents(); });
        }

        private async Task InitAsync()
        {
           await GetEvents();
        }

        private async Task GetEvents()
        {
            Events = await Api.GetEvents();
        }
    }
}
