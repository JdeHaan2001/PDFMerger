using System.Configuration;
using System.Data;
using System.Windows;

namespace PDFMerger
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzU1NTM4MEAzMjM3MmUzMDJlMzBwQmtWNjBIVlo2UFg0VGx4Um5aSDFNOFRYK3JlN3ltZC82MHRlRU9SVGNBPQ==");
        }
    }

}
