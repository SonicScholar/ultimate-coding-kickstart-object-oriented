using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class SimpleList<T> where T : IComparable<T>
    {
        const int MAX_SIZE = 100;
        T[] _storage;
        int _totalElements;

        public SimpleList()
        {
            _totalElements = 0;
            _storage = new T[MAX_SIZE];
        }

        public void Add(T item)
        {
            _storage[_totalElements] = item;
            _totalElements++;
        }

        public void PrintItems()
        {
            for (int i = 0; i < _totalElements; i++)
            {
                Console.WriteLine(_storage[i]);
            }
        }

        public void SimpleSort()
        {
            bool swapOccurred;
            do
            {
                swapOccurred = false;
                for (int i = 0; i < _totalElements-1; i++)
                {
                    T currentItem = _storage[i];
                    T nextItem = _storage[i + 1];
                    int compare = currentItem.CompareTo(nextItem);
                    if(compare > 0)
                    {
                        Swap(i, i + 1);
                        swapOccurred = true;
                    }
                }
            } while (swapOccurred);
        }

        private void Swap(int index1, int index2)
        {
            T temp = _storage[index1];
            _storage[index1] = _storage[index2];
            _storage[index2] = temp;
        }
    }
}
