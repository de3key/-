using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 237;
            int a = x/100;
            int b = x % 100;
            int x1 = b * 10 + a;
            Console.WriteLine(x1);
            Console.ReadKey();
        }
    }
}
