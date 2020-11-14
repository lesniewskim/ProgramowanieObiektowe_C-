using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, a, iloscLiczb = 0;
            do
            {
                Console.WriteLine("Podaj wykladnik:");
                a = int.Parse(Console.ReadLine());
                suma += a;
                iloscLiczb++;
            } while (a != 0);
            Console.WriteLine("Podałeś {0} liczb, Suma wpisanych liczb = {1}",
                iloscLiczb,
                suma);
            Console.ReadLine();
        }
    }
}
