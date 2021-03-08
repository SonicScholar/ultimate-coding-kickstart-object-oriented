using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Student : PersonBase
    {
        string _studentId;
        public Student(string studentId)
        {
            _studentId = studentId;
        }
        public DateTime EnrollmentDate { get; set; }

        public override string Id => _studentId;
    }
}
