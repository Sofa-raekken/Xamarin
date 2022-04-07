using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class EventAnimal
    {
        [JsonProperty("idAnimal")]
        public int IdAnimal { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonConstructor]
        public EventAnimal(int idAnimal, string name)
        {
            IdAnimal = idAnimal;
            Name = name;
        }
    }
}
