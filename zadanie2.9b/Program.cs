﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._9b
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0); //x nie jest wiekszy od ale jest bezwarunkowe i dlatego y sie zmienia
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

        }
    }
}
