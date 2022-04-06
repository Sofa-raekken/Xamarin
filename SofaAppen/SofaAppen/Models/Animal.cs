using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Animal
    {
        [JsonProperty(PropertyName = "idAnimal")]
        private int Id { get; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "latinName")]
        public string LationName { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public int Weight { get; set; }

        [JsonProperty(PropertyName = "lifeExpectancy")]
        public int LifeExpectancy { get; set; }

        [JsonProperty(PropertyName = "pregnancy")]
        public int Pregnancy { get; set; }

        [JsonProperty(PropertyName = "heigth")]
        public decimal Height { get; set; }

        [JsonProperty(PropertyName = "birthWeight")]
        public double BirthWeight { get; set; }

        [JsonProperty(PropertyName = "qr")]
        public string QR { get;set; }
    }
}
