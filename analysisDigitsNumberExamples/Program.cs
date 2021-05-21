using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analysisDigitsNumberExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); // 1024

            Console.WriteLine("a/10 = " + a / 10); // 102
            Console.WriteLine("a%10 = " + a % 10); // 4
            Console.ReadKey();
        }
    }
}