using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SofaAppen.Services
{
    public interface IQRScanningService
    {
        Task<string> ScanAsync();
    }
}
