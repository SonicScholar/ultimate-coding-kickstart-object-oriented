using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    class LawnCareAgency
    {
        List<ILawnCareProvider> _lawnCareProviders;
        public LawnCareAgency()
        {
            _lawnCareProviders = new List<ILawnCareProvider>();
            _lawnCareProviders.Add(new SonicScholarLawnCareProvider());
            _lawnCareProviders.Add(new MediocreLawnCareProvider());

        }

        public ILawnCareProvider GetBestProviderAvailable()
        {
            ILawnCareProvider result = null;

            int maxRating = 0;
            foreach (var p in _lawnCareProviders)
            {
                int rating = p.Rating;
                bool available = p.IsAvailable;
                if(rating  > maxRating && available)
                {
                    maxRating = rating;
                    result = p;
                }
            }
            return result;
        }
    }
}
