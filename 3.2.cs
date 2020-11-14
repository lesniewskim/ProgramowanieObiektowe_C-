using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program informuje czy pierwsza liczba jest dzielnikiem drugiej. ");
            Console.WriteLine("Podaj pierwszą liczbę: ");
            int liczba1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int liczba2 = Convert.ToInt32(Console.ReadLine());

            if (liczba2 == 0)
            {
                Console.WriteLine("Nie dziel przez zero!");
            }
            else
                if (liczba1 % liczba2 == 0)
            {
                Console.WriteLine("Liczba jest dzielnikiem podanej liczby.");
            }
            else
            {
                Console.WriteLine("Liczba nie jest dzielnikiem podanej liczby");
            }
            Console.ReadKey();

        }
    }
}
