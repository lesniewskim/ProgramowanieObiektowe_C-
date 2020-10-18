using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, wynik;
            Console.WriteLine("ile stopni Celcjusza zamienić na stopnie Fahrenheita: ");
            c = double.Parse(Console.ReadLine());
            wynik = 32 + (9 / 5) * c;
            Console.WriteLine(wynik);
            Console.ReadKey();

        }
    }
}
