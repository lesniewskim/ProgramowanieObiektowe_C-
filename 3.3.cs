using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program znajduje największą spośród trzech podanych liczb");
            Console.WriteLine("Podaj pierwszą liczbę");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj trzecią liczbę");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("Największa jest liczba:");
                Console.WriteLine(a);
            }

            else if (b > a && b > c)
            {
                Console.WriteLine("Największa jest liczba:");
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Największa jest liczba:");
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
