package com.sonicscholar;

import java.util.Date;


public class Main {

    public static void main(String[] args) {
        Employee janeDoe = new Employee("Jane", "Doe", "123", 15);
        janeDoe.GiveRaise(1);
        double pay = janeDoe.CalculatePay(40);
    }

}
