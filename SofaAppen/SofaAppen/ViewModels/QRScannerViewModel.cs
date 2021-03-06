using SofaAppen.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SofaAppen.ViewModels
{
    public class QRScannerViewModel : BaseViewModel
    {
        public Command QrScanCommand { get; set; }
        public IQRScanningService Scanner { get; }
        public IApiClient Api { get; }

        public QRScannerViewModel()
        {
            Scanner = DependencyService.Get<IQRScanningService>();
            Api = DependencyService.Get<IApiClient>();


            QrScanCommand = new Command(async () => { await InitQRScan(); });

        }

        private async Task InitQRScan()
        {
            try
            {
                var result = await Scanner.ScanAsync();

                int animalId = 0;

                if (result != null && int.TryParse(result, out animalId))
                {
                    await NavigateToDetailPage(animalId);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task NavigateToDetailPage(int animalId)
        {
            await Shell.Current.GoToAsync($"animals/details?animalId={animalId}");
        }
    }
}
