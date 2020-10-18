using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 5;
            x = ++y;    //x = 6 y = 6
            x = y++;    //x = 7 y = 7
            x = --y;    //x = 6 y = 6
            x = y--;    //x = 6 y = 5 
            Console.WriteLine(y++); // y = 5 po wyswietleniu zwiekszy swoja wartosc
            Console.ReadKey();
        }
    }
}
