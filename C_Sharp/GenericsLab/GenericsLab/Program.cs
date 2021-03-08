using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //List<int> randomInts = new List<int>();
            SimpleList<int> randomInts = new SimpleList<int>();

            for (int i = 0; i < 10; i++)
            {
                int r = random.Next(0, 9);
                randomInts.Add(r);
            }

            Console.WriteLine("Before Sort:");
            randomInts.PrintItems();
            Console.WriteLine();

            randomInts.SimpleSort();
            Console.WriteLine("After Sort:");
            randomInts.PrintItems();
            Console.WriteLine();

            SimpleList<string> fruits = new SimpleList<string>();
            fruits.Add("orange");
            fruits.Add("banana");
            fruits.Add("grapes");
            fruits.Add("apples");
            fruits.Add("tangerine");

            Console.WriteLine("Before Sort:");
            fruits.PrintItems();
            Console.WriteLine();

            fruits.SimpleSort();
            Console.WriteLine("After Sort:");
            fruits.PrintItems();

        }
    }
}
