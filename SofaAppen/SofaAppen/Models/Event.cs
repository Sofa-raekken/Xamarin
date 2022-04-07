using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Event
    {

        [JsonProperty("idEvent")]
        public int IdEvent { get; set; }

        [JsonProperty("name")]
        public int Name { get; set; }

        [JsonProperty("description")]
        public int Description { get; set; }

        [JsonProperty("animals")]
        public List<EventAnimal> Animals { get; set; }

        [JsonConstructor]
        public Event(int idEvent, int name, int description, List<EventAnimal> animals)
        {
            IdEvent = idEvent;
            Name = name;
            Description = description;
            Animals = animals;
        }
    }
}
