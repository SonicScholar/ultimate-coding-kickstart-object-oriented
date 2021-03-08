using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    interface ILawnCareProvider
    {
        void BookMowing();
        void BookRaking();
        void BookWeedRemoval();
        bool IsAvailable { get; }
        int Rating { get; }
    }
}
