using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific_Number
{
    public class Sum
    {

        public int a, b, c, d, e, f, g, h, i, j;
        public void Test()
        {
            NumberofTest = 10;
            a = TestScore();
            b = TestScore();
            c = TestScore();
            d = TestScore();
            e = TestScore();
            f = TestScore();
            g = TestScore();
            h = TestScore();
            i = TestScore();
            j = TestScore();

            Console.WriteLine((a + b + c + d + e + f + g + h + i + j) / 10);
            Console.ReadLine();
            int[] testarray = new int[] { a, b, c, d, e, f, g, h, i, j };
            for (int i = 0; i < testarray.Length; i++) ;
        }

        public int TestScore()
        {
            Console.WriteLine($"Enter a test score between 0 to 100:   ");
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 100)
            {
                Console.WriteLine("ERROR: Not a valid test score please enter a valid number between 0 to 100");
                a = int.Parse(Console.ReadLine());
            }
            return a;
        }


        public int NumberofTest { get; set; }

        public void AssignTest(int x)
        {
            NumberofTest = x;
        }

        public void EnterTest()
        {
            int Grades = 0;
            for (int i = 0; i < NumberofTest; i++)
            {
                Console.WriteLine("Enter test grade " + i);
                Grades = Grades + int.Parse(Console.ReadLine());

            }
            int Average = Grades / NumberofTest;
            Console.WriteLine("Your average is " + Average.ToString());
            Console.WriteLine(Letter_Grade(Average));

        }

        public string Letter_Grade(int Value)
        {

            if (Value >= 90)// || Value < 100)
            {
                return "Letter grade is A";
            }

            if (Value >= 80)// || Value < 89)
            {
                return "Letter grade is B";
            }

            if (Value >= 70)// || Value < 79)
            {
                return "Letter grade is C";
            }

            if (Value >= 60)// || Value < 69)
            {
                return "Letter grade is D";
            }

            else
            {
                return "Letter grade if F";
            }

        }

    }
}



