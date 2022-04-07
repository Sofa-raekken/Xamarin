using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Animal
    {
        public Animal()
        {

        }
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

        [JsonConstructor]
        public Animal(int id, string name, string lationName, string description, string weight, string lifeExpectancy, string pregnancy, string height, string birthWeight, string qR)
        {
            Id = id;
            Name = name;
            LationName = lationName;
            Description = description;
            Weight = weight;
            LifeExpectancy = lifeExpectancy;
            Pregnancy = pregnancy;
            Height = height;
            BirthWeight = birthWeight;
            QR = qR;
        }    
        public Animal(int id, string name)
        {
            Id = id;
            Name = name;
        }

    }
}
