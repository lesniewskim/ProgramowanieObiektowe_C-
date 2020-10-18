using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //odp x=true i z=2
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine(x);
            Console.WriteLine(z);
        }
    }
}
