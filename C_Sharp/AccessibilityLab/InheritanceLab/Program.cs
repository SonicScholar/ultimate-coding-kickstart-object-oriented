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

            Coordinate c1 = new Coordinate(0, 0);
            Coordinate c2 = new Coordinate(1, 1);

            double dist = c1.DistanceTo(c2);
            Console.WriteLine(dist);

            double dist2 = Coordinate.DistanceBetween(c1, c2);
            Console.WriteLine(dist);

            double dist3 = c2.DistanceFromOrigin();
            Console.WriteLine(dist);

            double dist4 = c2.DistanceFromOrigin();
            Console.WriteLine(dist);


            //Student s = new Student("123")
            //{
            //    FirstName = "Collin",
            //    LastName = "Tewalt",
            //};

            //string studentInfo = s.GetInfo();

            //FacultyMember f = new FacultyMember("234")
            //{
            //    FirstName = "Harold",
            //    LastName = "Dawson"
            //};


            //PersonBase personBase = (PersonBase)f;
            //string personInfo = personBase.GetInfo();

            //string facultyInfo = f.GetInfo();

            //Console.WriteLine(studentInfo);
            //Console.WriteLine(facultyInfo);

            Console.ReadLine();
        }
    }
}
