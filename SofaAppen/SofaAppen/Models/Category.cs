using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SofaAppen.Models
{
    public class Category
    {
        [JsonProperty("idCategory")]
        public int IdCategory { get; set; }

        [JsonProperty("category")]
        public string CategoryName { get; set; }

        [JsonConstructor]
        public Category(int idCategory, string category)
        {
            IdCategory = idCategory;
            CategoryName = category;
        }
    }
}
