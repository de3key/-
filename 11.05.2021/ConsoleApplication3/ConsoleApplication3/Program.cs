﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.32
            Console.WriteLine("СНИГГЕРС ВВЕДИ ЧИСЛО");
            int a = Convert.ToInt32(Console.ReadLine());
            int min = -1;
            int n = 0;
            int b = a;
            while (a != 0)
            {
                int a1 = a % 10;
                a = a / 10;
                if (a1 < min || min == -1)
                {
                    min = a1;
                }
               
            }
            while (b != 0)
                {
                    int b1 = b % 10;
                    b = b / 10;
                    if (b1 == min)
                    {
                        n++;
                    }
                }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
