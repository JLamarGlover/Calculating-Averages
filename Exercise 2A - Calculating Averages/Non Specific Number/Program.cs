using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter test score or type finsih to complete process");
            Endless endless = new Endless();
            endless.TestScore();
            Console.ReadLine();

        }
    }
}
