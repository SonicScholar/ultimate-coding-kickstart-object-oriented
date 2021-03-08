using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsLab
{
    class Employee
    {
        string _firstName;
        string _lastName;
        string _idNumber;
        double _hourlyRate;

        public Employee(string firstName, string lastName, string idNumber, double hourlyRate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _idNumber = idNumber;
            _hourlyRate = hourlyRate;
        }

        public void GiveRaise(double increaseRateAmount)
        {
            _hourlyRate += increaseRateAmount;
        }

        public double CalculatePay(double hours)
        {
            return _hourlyRate* hours;
        }
    }
}
