using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица умножения");
            double k = Convert.ToDouble(Console.ReadLine());
            for (int i=0; i<=90; i= i + 9)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
