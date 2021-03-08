using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesReferenceTypesLab
{
    enum GameMove
    {
        Rock,
        Paper,
        Scissors
    }

    class Box
    {
        public int BoxId { get; set; }
        public Box InsideBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // write your code here
            int i = 1;

            bool b1 = true;
            Boolean b2 = true;

            string s = "hello world";

            int[] array = { 1, 2, 3 };

            GameMove g = GameMove.Rock;
            System.Enum e;

            Box b = new Box();
            b.BoxId = 1;
            Foo(out b);

            string strNumber = "23452";
            bool success = int.TryParse(strNumber, out int num);
        }

        public static void Foo(out Box b)
        {
            b = new Box();
            b.BoxId = 2;
            b.InsideBox = b;
            b = null;
        }

    }
}
