using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remainderDivisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1024;
            Console.WriteLine("a % 10 = " + a % 10); // 4
            Console.WriteLine("a % 100 = " + a % 100); // 24
            Console.WriteLine("a % 1000 = " + a % 1000); // 24
            Console.WriteLine("a % 10000 = " + a % 10000); // 1024
            Console.ReadKey();
        }
    }
}