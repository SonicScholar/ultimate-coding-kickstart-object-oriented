using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class FacultyMember : PersonBase
    {

        private string _facultyId;
        public FacultyMember(string facultyId)
        {
            _facultyId = facultyId;
        }        

        public DateTime DateOfHire { get; set; }
        public bool IsTenured { get; set; }

        //public override string Id => _facultyId;
        public override string Id
        {
            get
            {
                return _facultyId;
            }
        }

        public override string GetInfo()
        {
            return base.GetInfo() + ": " + _facultyId;
        }
    }
}
