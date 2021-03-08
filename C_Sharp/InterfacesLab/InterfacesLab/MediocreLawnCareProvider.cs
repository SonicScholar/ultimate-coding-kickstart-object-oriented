using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    class MediocreLawnCareProvider : ILawnCareProvider
    {
        public bool IsAvailable => true;

        public int Rating => 3;

        public void BookMowing()
        {
        }

        public void BookRaking()
        {
        }

        public void BookWeedRemoval()
        {
        }
    }
}
