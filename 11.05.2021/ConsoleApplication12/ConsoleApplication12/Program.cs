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
            Console.WriteLine("Cниггерс йоу йоу йоу йоу");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cниггерс йоу йоу йоу йоу");
            double v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cниггерс йоу йоу йоу йоу");
            double m2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cниггерс йоу йоу йоу йоу");
            double v2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cниггерс йоу йоу йоу йоу");
            double p1 = m1 / v1;
            double p2 = m2 / v2;
            if (p1 > p2)
            {
                Console.WriteLine("КОРОЧЕ НАДОЕЛО ТУТ БУДЕТ ЧТО ТО");
            }
            else if (p1 < p2)
            {
                Console.WriteLine("КОРОЧЕ НАДОЕЛО ТУТ БУДЕТ ЧТО ТО");
            }
            Console.ReadKey();
        }
    }
}
