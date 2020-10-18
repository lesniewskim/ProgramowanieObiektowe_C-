using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przyklad2._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 10;
            a = b = c; // od prawej do lewej
            Console.WriteLine(a);
            Console.WriteLine(a + b + c); // od lewej do prawej
            Console.ReadKey();

        }
    }
}
