using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Podaj a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = double.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            Console.WriteLine("delta= " + delta);

        }
    }
}
