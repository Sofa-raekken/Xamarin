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
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("animals")]
        public List<Animal> Animals { get; set; }

        [JsonConstructor]
        public Event(int idEvent, string name, string description, List<Animal> animals)
        {
            IdEvent = idEvent;
            Name = name;
            Description = description;
            Animals = animals;
        }
    }
}
