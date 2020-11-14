using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbacyfr = 0, sum = 0, liczba = 1;
            while (sum < 100)
            {
                liczbacyfr++;
                sum += liczba;
                liczba++;
            }
            Console.Write("Ilość użytych liczb: {0} | Największa użyta liczba: {1} | Suma: {2}", liczbacyfr, liczba, sum);
            Console.ReadKey();
        }
    }
}
