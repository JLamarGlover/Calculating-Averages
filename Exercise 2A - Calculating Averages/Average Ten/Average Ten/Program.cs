using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Ten
{
    class ProgramAverage
    {
        static void Main(string[] args)
        {
            Sum average = new Sum();
            average.Test();
            average.EnterTest();
            Console.ReadLine();
            Console.WriteLine("Please enter the number of test");
        }   
    }
}
