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
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double y4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Я НЕ СНИГГЕРС НО ТЫ ТОЖЕ НЕ СНИКЕРС");
            double a12 = Math.Sqrt(Math.Pow(x1 - x2, 2) + (Math.Pow(y1 - y2, 2)));
            double a23 = Math.Sqrt(Math.Pow(x2 - x3, 2) + (Math.Pow(y2 - y3, 2)));
            double a34 = Math.Sqrt(Math.Pow(x3 - x4, 2) + (Math.Pow(y3 - y4, 2)));
            double a31 = Math.Sqrt(Math.Pow(x3 - x1, 2) + (Math.Pow(y3 - y1, 2)));
            double a41 = Math.Sqrt(Math.Pow(x4 - x1, 2) + (Math.Pow(y4 - y1, 2)));
            double p1 = (a12 + 23 + a31)/2;
            double p2 = (a34 + a31 + a41)/2;
            double s1 = Math.Sqrt(p1*(p1 - a12)*(p1 - a23)*(p1 - a31));
            double s2 = Math.Sqrt(p2 * (p2 - a34) * (p2 - a31) * (p1 - a41));
            double s21 = s1 + s2;
            Console.WriteLine("Сниггерс введи"+ s21);
            Console.ReadKey();
        }
    }
}
