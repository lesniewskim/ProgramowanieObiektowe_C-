using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {

            double F, C;
            Console.WriteLine("Podaj temp w stopniach Fahrenheita");
            F = double.Parse(Console.ReadLine());
            C = 5f / 9 * (F - 32);
            Console.WriteLine(C);
            Console.ReadKey();

        }
    }
}
