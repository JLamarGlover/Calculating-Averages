using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Numbers
{
    public class Sum
    {
        public int a, b, c, d, e, f, g, h, i, j;
        public void Test()
        {
            a = TestScore(1);
            b = TestScore(2);
            c = TestScore(3);
            d = TestScore(4);
            e = TestScore(5);
            f = TestScore(6);
            g = TestScore(7);
            h = TestScore(8);
            i = TestScore(9);
            j = TestScore(10);

            Console.WriteLine(a + b + c + d + e + f + g + h + i + j);
            Console.ReadLine();
            int[] testarray = new int[] { a, b, c, d, e, f, g, h, i, j };
            for (int i = 0; i < testarray.Length; i++);  
        }

        public int TestScore(int TS)
        {
            Console.WriteLine($"Enter a test score between 0 to 100: {TS}   ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 100)
            {
                Console.WriteLine("ERROR: Not a valid test score please enter a valid number between 0 to 100");
                a = int.Parse(Console.ReadLine());
            }
            return a;
        }
    }
}
