using SofaAppen.Models;
using SofaAppen.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using Xamarin.Forms;

namespace SofaAppen.ViewModels
{
    public class AnimalDetailViewModel : BaseViewModel, IQueryAttributable
    {
        private Animal _animal;
        public Animal Animal { get { return _animal; } set { _animal = value; OnPropertyChanged(); } }
        public IApiClient Api { get; }

        public AnimalDetailViewModel() {
            Api = DependencyService.Get<IApiClient>();
        }
        public void ApplyQueryAttributes(IDictionary<string, string> query)
        {
            // The query parameter requires URL decoding.
            string animalId = HttpUtility.UrlDecode(query["animalId"]);
            int intanimalId;
            if (int.TryParse(animalId, out intanimalId))
            {
                GetAnimalDetail(intanimalId);

            }
        }
        public async void GetAnimalDetail(int animalId)
        {
            Animal = await Api.GetAnimal(animalId);
        }
    }
}
