using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y =  4 ;
            x = (y += 3);
            x = ++y;
            x = y--;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
