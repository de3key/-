using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Что то на умном");
            double s = 0;            
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                s=s+(1.0 / i);
            }
            Console.ReadKey();
        }
    }
}
