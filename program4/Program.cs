using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Podaj x (większe o 0)");
            x = Convert.ToDouble(Console.ReadLine());
            y = Math.Sqrt(Math.Abs(Math.Sin(x)) * Math.Log(x, 2.0));
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
