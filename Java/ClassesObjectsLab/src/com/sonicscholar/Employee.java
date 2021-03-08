package com.sonicscholar;

import java.util.Date;

public class Employee {
    String _firstName;
    String _lastName;
    String _idNumber;
    double _hourlyRate;

    public Employee(String firstName, String lastName, String idNumber, double hourlyRate) {
        _firstName = firstName;
        _lastName = lastName;
        _idNumber = idNumber;
        _hourlyRate = hourlyRate;
    }

    public void GiveRaise(double increaseRateAmount) {
        _hourlyRate += increaseRateAmount;
    }

    public double CalculatePay(double hours) {
        return _hourlyRate * hours;
    }
}
