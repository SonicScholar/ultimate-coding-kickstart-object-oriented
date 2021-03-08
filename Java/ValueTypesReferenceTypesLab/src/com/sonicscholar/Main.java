package com.sonicscholar;


enum GameMove {
    Rock,
    Paper,
    Scissors;
}

class Box {
    public int boxId = 0;
    public Box insideBox;
}

//MAIN
public class Main {
    public static void main(String[] args) {
	    // write your code here
        int i = 1;
        Integer j = 1;

        boolean b1 = true;
        Boolean b2 = true;

        String s = "hello world";

        int[] array = {1,2,3};

        GameMove g = GameMove.Rock;

        Box b = new Box();
        b.boxId = 1;
        foo(b);
    }

    public static void foo(Box b){
        b.boxId = 2;
        b.insideBox = b;

        b = new Box();
        b.boxId = 3;
    }

}
