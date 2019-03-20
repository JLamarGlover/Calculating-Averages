using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specific_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.WriteLine("Please enter the number of test");
            Sum arbitrary = new Sum();
            arbitrary.NumberofTest = (int.Parse(Console.ReadLine()));
            arbitrary.EnterTest();
            Console.ReadLine();
        }
    }
}
