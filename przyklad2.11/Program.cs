﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przyklad2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 10;
            bool wynik;
            wynik = (x >= 2 || y++ >= 2);
            Console.WriteLine(wynik);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}
