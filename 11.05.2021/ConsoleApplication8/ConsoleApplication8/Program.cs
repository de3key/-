using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я НЕ СНИГГЕРС НО ЭТО КОД");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (a1 == 3)
                {
                    Console.WriteLine("Так да");
                }
                else
                {
                    Console.WriteLine("Так нет");
                }

                Console.WriteLine(n);
                Console.ReadKey();
            }
        }

    }
}