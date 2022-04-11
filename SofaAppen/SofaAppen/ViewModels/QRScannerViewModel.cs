using SofaAppen.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

namespace SofaAppen.ViewModels
{
    public class QRScannerViewModel : BaseViewModel
    {
        public QRScannerViewModel()
        {
            InitQRScan();
        }

        private async void InitQRScan()
        {
            try
            {
                //var scanner = DependencyService.Get<IQRScanningService>();
                var result = await ScanAsync();

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

        public async Task<string> ScanAsync()
        {
            //Scan Options
            var optionsCustom = new MobileBarcodeScanningOptions();
            optionsCustom.UseNativeScanning = true;

            MobileBarcodeScanner scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Come closer to the QR kode",
                CancelButtonText = "Return"
            };

            //Activate QR Scanner and awaiting QR to scan
            var scanResult = await scanner.Scan(optionsCustom);

            if (scanResult != null)
            {
                return scanResult.Text;

            }
            return null;
        }

        public async Task NavigateToDetailPage(int animalId)
        {
            await Shell.Current.GoToAsync($"animals/details?animalId={animalId}");
        }
    }
}
