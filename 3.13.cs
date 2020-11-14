using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;
            Console.WriteLine("Podaj liczbę");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    suma -= i;
                else
                    suma += i;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
