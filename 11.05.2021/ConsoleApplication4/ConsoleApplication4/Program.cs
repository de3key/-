using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.33
            int i = 13;
            while (i < 100) 
            {
                Console.WriteLine(i);
                i = i + 13;
            }
            Console.ReadKey();
        }
    }
}
