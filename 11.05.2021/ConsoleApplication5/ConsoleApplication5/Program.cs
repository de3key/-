using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.34
            int a = 500;
            int n = 0;
            while (n <= 20)
            {
                if (a % 13 == 0 || a % 17 == 0)
                {
                    n++;
                    Console.WriteLine(a);                    
                }
                a = a + 1;
            }
            Console.ReadKey();
        }
    }
}
