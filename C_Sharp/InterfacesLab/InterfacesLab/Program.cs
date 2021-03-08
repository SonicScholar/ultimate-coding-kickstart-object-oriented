using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    class Program
    {
        static void Main(string[] args)
        {

            LawnCareAgency agency = new LawnCareAgency();
            ILawnCareProvider provider = agency.GetBestProviderAvailable();
            provider.BookMowing();

            provider = agency.GetBestProviderAvailable();
            provider.BookRaking();

            provider = agency.GetBestProviderAvailable();
            provider.BookWeedRemoval();

            provider = agency.GetBestProviderAvailable();
            provider.BookRaking();

            provider = agency.GetBestProviderAvailable();
            provider.BookMowing();















            //ILawnCareProvider ssProvider = new SonicScholarLawnCareProvider();
            //ILawnCareProvider mediocoreProvider = new MediocreLawnCareProvider();

            //bool available = ssProvider.IsAvailable;
            //ssProvider.BookMowing();

            //available = ssProvider.IsAvailable;
            //ssProvider.BookRaking();

            //available = ssProvider.IsAvailable;
            //ssProvider.BookWeedRemoval();

            //available = ssProvider.IsAvailable;
        }
    }
}
