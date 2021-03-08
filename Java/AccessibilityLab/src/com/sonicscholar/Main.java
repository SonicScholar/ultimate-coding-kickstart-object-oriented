package com.sonicscholar;

import java.util.Date;

public class Main {

    public static void main(String[] args) {
//        Student s = new Student("123", "Collin", "Tewalt");
//	    FacultyMember f = new FacultyMember("234", "Harold", "Dawson");
//	    Person p = f;

        Coordinate c1 = new Coordinate(0, 0);
        Coordinate c2 = new Coordinate(1,1);

        double dist = c1.distanceTo(c2);
        dist = Coordinate.distanceBetween(c1, c2);
        System.out.println(dist);

        double distanceFromOrigin = c2.distanceFromOrigin();
        distanceFromOrigin = c2.distanceFromOrigin();

//        int x = c1.getX();
//        int y = c1.getY();
//
//        System.out.println("x: "+ x);
//        System.out.println("y: "+ y);
    }
}
