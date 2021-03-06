using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    abstract class PersonBase : IPerson
    {
        public abstract string Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual string GetInfo()
        {
            return LastName + ", " + FirstName;
        }
    }
}
