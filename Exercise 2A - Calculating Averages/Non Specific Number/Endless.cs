using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Number
{
    class Endless
    {
        public bool finish { get; set; }
        Sum test = new Sum();

        public void TestScore()
        {
            finish = false;
            int score = 0;
            test.NumberofTest = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter test score or type finish to complete process");
                string input = Console.ReadLine();
                if (input != "finish")
                {
                    score += int.Parse(input);
                    test.NumberofTest++;
                }
                else
                {
                    finish = true;
                }

            } while (finish == false);

            int Average = score / test.NumberofTest;

            Console.WriteLine("Your average is " + Average.ToString());
            Console.WriteLine(test.Letter_Grade(Average));

        }
    }
}
