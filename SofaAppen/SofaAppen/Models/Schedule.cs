using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Schedule
    {
        [JsonProperty(PropertyName = "eventId")]
        public int EventId { get; }
        [JsonProperty(PropertyName = "eventName")]
        public string Name { get; set; }
        [JsonProperty(PropertyName = "occurringDate")]
        public DateTime DateTime { get; set; }

        [JsonConstructor]
        public Schedule(int eventId, string name, DateTime dateTime)
        {
            EventId = eventId;
            Name = name;
            DateTime = dateTime;
        }
    }
}
