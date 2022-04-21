using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;


namespace SofaAppen.Services
{
    public class QrScanningService : IQRScanningService
    {
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
    }
}