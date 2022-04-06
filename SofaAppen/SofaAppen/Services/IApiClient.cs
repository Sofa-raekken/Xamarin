using SofaAppen.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SofaAppen.Services
{
    public interface IApiClient
    {
        Task<List<Animal>> GetAnimals();
        Task<Animal> GetAnimal(int id);
        Task<List<Event>> GetEvents();
    }
}
