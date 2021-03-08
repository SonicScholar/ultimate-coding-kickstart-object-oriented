package com.sonicscholar;

import java.util.ArrayList;
import java.util.Random;

public class Main {

    public static void main(String[] args) {
	// write your code here
        Integer n;
        //ArrayList<Integer> randomInts = new ArrayList<>();
        SimpleList<Integer> randomInts = new SimpleList<>();
        Random random = new Random();

        for(int i=0; i< 10; i++) {
            int r = random.nextInt(10);
            randomInts.add(r);
        }

        System.out.println("Before sort:");
        randomInts.printList();
        System.out.println();

        randomInts.sort();
        System.out.println("After sort:");
        randomInts.printList();
        System.out.println();


        SimpleList<String> fruits = new SimpleList<>();
        fruits.add("orange");
        fruits.add("grape");
        fruits.add("watermelon");
        fruits.add("apple");
        fruits.add("banana");

        System.out.println("Before sort:");
        fruits.printList();
        System.out.println();

        fruits.sort();
        System.out.println("After sort:");
        fruits.printList();

    }
}
