using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Просто число");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = 0;

            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
