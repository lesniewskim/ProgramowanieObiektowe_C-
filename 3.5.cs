using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta;
            Console.WriteLine("Program oblicza deltę");
            Console.WriteLine("Podaj a ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c ");
            c = double.Parse(Console.ReadLine());

            delta = (b * b) - (4 * a * c);
            Console.WriteLine("Delta wynosi: ");
            Console.WriteLine(delta);

            if(delta == 0)
            Console.WriteLine("Jedno miejsce zerowe");
            else if(delta > 0)
            {
                Console.WriteLine("Dwa miejsca zerowe");
            }    
            else
            {
                Console.WriteLine("Brak miejsc zerowych");
            }
            Console.ReadKey();
        }
    }
}
