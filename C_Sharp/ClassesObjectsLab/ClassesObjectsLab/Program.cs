using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee jane = new Employee("Jane", "Doe", "123", 15);
            jane.GiveRaise(1.0);
            double pay = jane.CalculatePay(40);
        }
    }
}
