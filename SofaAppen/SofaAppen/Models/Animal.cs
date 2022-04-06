using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Animal
    {
        [JsonProperty(PropertyName = "idAnimal")]
        public int Id { get; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "latinName")]
        public string LationName { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "weight")]
        public string Weight { get; set; }

        [JsonProperty(PropertyName = "lifeExpectancy")]
        public string LifeExpectancy { get; set; }

        [JsonProperty(PropertyName = "pregnancy")]
        public string Pregnancy { get; set; }

        [JsonProperty(PropertyName = "heigth")]
        public string Height { get; set; }

        [JsonProperty(PropertyName = "birthWeight")]
        public string BirthWeight { get; set; }

        [JsonProperty(PropertyName = "qr")]
        public string QR { get;set; }
    }
}
