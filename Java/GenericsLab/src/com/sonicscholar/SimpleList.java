package com.sonicscholar;

public class SimpleList<T extends Comparable<T>> {
    private static int MAX_SIZE = 100;
    private Object[] _storage;
    private int _totalElements;

    public SimpleList() {
        _storage = new Object[MAX_SIZE];
        _totalElements = 0;
    }

    public void add(T item) {
        _storage[_totalElements] = item;
        _totalElements++;
    }

    public void sort() {
        boolean swapOccurred;
        do {
            swapOccurred = false;
            for(int i=0; i< _totalElements -1; i++)
            {
                T currentItem = (T)_storage[i];
                T nextItem = (T)_storage[i+1];
                if(currentItem.compareTo(nextItem) > 0)
                {
                    swap(i, i+1);
                    swapOccurred = true;
                }
            }
        }while(swapOccurred);
    }

    private void swap(int index1, int index2) {
        Object temp = _storage[index1];
        _storage[index1] = _storage[index2];
        _storage[index2] = temp;
    }

    public void printList(){
        for (int i=0; i<_totalElements; i++) {
            System.out.println(_storage[i]);
        }
    }
}
