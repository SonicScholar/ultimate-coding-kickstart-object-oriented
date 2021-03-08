package com.sonicscholar;

public class Coordinate {
    private int _x;
    private int _y;

    public static final Coordinate ORIGIN = new Coordinate(0,0);

    public Coordinate(int x, int y) {
        _x = x;
        _y = y;
    }

    public int getX(){ return _x;}
    public int getY(){ return _y;}

    public double distanceTo(Coordinate other){
        double xDist = this._x - other._x;
        double yDist = this._y - other._y;

        double xDistSquared = xDist * xDist;
        double yDistSquared = yDist * yDist;

        //c^2 = a^2 + b^2
        //c = sqrt(a^2 + b^2)

        double distSquared = xDistSquared + yDistSquared;
        double distance = Math.sqrt(distSquared);
        return distance;
    }

    public static double distanceBetween(Coordinate c1, Coordinate c2){
        double xDist = c1._x - c2._x;
        double yDist = c1._y - c2._y;

        double xDistSquared = xDist * xDist;
        double yDistSquared = yDist * yDist;

        //c^2 = a^2 + b^2
        //c = sqrt(a^2 + b^2)

        double distSquared = xDistSquared + yDistSquared;
        double distance = Math.sqrt(distSquared);
        return distance;
    }

    public double distanceFromOrigin(){
        return distanceTo(ORIGIN);
    }
}
