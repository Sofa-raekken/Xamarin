using SofaAppen.Models;
using SofaAppen.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Xamarin.Forms;

namespace SofaAppen.ViewModels
{

    public class EventDetailViewModel : BaseViewModel, IQueryAttributable
    {
        private Event _event;
        public Event Event { get { return _event; } set { _event = value; OnPropertyChanged(); } }
        public IApiClient Api { get; }

        public EventDetailViewModel()
        {
            Api = DependencyService.Get<IApiClient>();
        }
        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            // The query parameter requires URL decoding.
            string eventId = HttpUtility.UrlDecode(query["eventId"]);
            int intEventId;
            if (int.TryParse(eventId, out intEventId))
            {
                GetEventDetail(intEventId);

            }
        }
        public async void GetEventDetail(int eventId)
        {
            Event = await Api.GetEvent(eventId);
        }
    }
}
