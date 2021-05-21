using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1024;
            Console.WriteLine("a / 10 = " + a / 10); // 102
            Console.WriteLine("a / 100 = " + a / 100); // 10
            Console.WriteLine("a / 1000 = " + a / 1000); // 1
            Console.WriteLine("a / 10000 = " + a / 10000); // 0
            Console.ReadKey();
        }
    }
}