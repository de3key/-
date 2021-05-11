using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.46
            Console.Write("Введите натуральное число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 0;
            while (a != 0)
            {
               int a1 = a + a % 10;
                a = a / 10;
                s = s + a1;
            }
            if (s >= 10)
            {
                Console.WriteLine("Так да");
            }
            else
            {
                Console.WriteLine("Так нет");
            }
            Console.ReadKey();


        }
    }
}
