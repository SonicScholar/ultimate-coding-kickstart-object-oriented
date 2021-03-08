using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("123")
            {
                FirstName = "Collin",
                LastName = "Tewalt",
            };

            string studentInfo = s.GetInfo();

            FacultyMember f = new FacultyMember("234")
            {
                FirstName = "Harold",
                LastName = "Dawson"
            };

            PersonBase personBase = (PersonBase)f;
            string personInfo = personBase.GetInfo();

            string facultyInfo = f.GetInfo();

            Console.WriteLine(studentInfo);
            Console.WriteLine(facultyInfo);

            Console.ReadLine();
        }
    }
}
