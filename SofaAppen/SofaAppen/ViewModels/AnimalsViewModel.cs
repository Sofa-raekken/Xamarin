using SofaAppen.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SofaAppen.ViewModels
{
    public class AnimalsViewModel : BaseViewModel
    {
        public Command ShowAnimal { get; set; }

        private List<Animal> _animals;
        public List<Animal> Animals { get { return _animals; } set { _animals = value; OnPropertyChanged(); } }

        private Animal _animal;
        public Animal Animal { get { return _animal; } set { _animal = value; OnPropertyChanged(); } }

        public AnimalsViewModel()
        {
            _animals = new List<Animal>();
            ShowAnimal = new Command(async () => { await NavigateToDetailPage(); });
            Task.Run(async () => { await InitAsync(); });
            
        }

        public async Task NavigateToDetailPage()
        {
            await Shell.Current.GoToAsync($"animals/details?animalId={Animal.Id}");
        }

        private async Task InitAsync()
        {
            await GetAnimals();
        }
        public async Task GetAnimals()
        {
            Animals = await Api.GetAnimals();

        }
    }
}
