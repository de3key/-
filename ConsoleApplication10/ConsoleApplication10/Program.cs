using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int k = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 20; i <= 35; i++)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
