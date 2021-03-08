using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    class SonicScholarLawnCareProvider : ILawnCareProvider
    {
        int _totalJobCount;
        public SonicScholarLawnCareProvider()
        {
            _totalJobCount = 0;
        }

        public void BookMowing()
        {
            _totalJobCount++;
        }

        public void BookRaking()
        {
            _totalJobCount++;
        }
        public void BookWeedRemoval()
        {
            _totalJobCount++;
        }

        public bool IsAvailable
        {
            get
            {
                return _totalJobCount < 3;
            }
        }

        public int Rating
        {
            get
            {
                return 5;
            }
        }

        public int TotalJobCount
        {
            get
            {
                return _totalJobCount;
            }
        }
    }
}
