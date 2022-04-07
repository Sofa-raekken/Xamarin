using Newtonsoft.Json;
using SofaAppen.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SofaAppen.Services
{
    public class ApiClient : IApiClient
    {
        static readonly HttpClient client = new HttpClient();

        public async Task<List<Animal>> GetAnimals()
        {
            HttpResponseMessage response = await client.GetAsync("https://sofaapi.azurewebsites.net/animals/");

            response.EnsureSuccessStatusCode();

            var jsonString = await response.Content.ReadAsStringAsync();

            var exercises = JsonConvert.DeserializeObject<List<Animal>>(jsonString);


            return exercises;
        }

        public async Task<Animal> GetAnimal(int id)
        {
            string URI = string.Format("https://sofaapi.azurewebsites.net/animals/{0}", id);

            HttpResponseMessage response = await client.GetAsync(URI);

            response.EnsureSuccessStatusCode();

            string jsonString = await response.Content.ReadAsStringAsync();

            Animal animal = JsonConvert.DeserializeObject<Animal>(jsonString);

            return animal;
        }

        public async Task<List<Event>> GetEvents()
        {
            HttpResponseMessage resp = await client.GetAsync("https://sofaapi.azurewebsites.net/events");

            resp.EnsureSuccessStatusCode();

            var data = await resp.Content.ReadAsStringAsync();

            List<Event> events = JsonConvert.DeserializeObject<List<Event>>(data);

            return events;
        }
    }
}
