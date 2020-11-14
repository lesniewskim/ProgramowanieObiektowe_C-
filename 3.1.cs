using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Program sprawdza czy dany rok jest rokiem przestępnym.");
        
            Console.WriteLine("Podaj rok. ");
            int rok = int.Parse(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
            {
                Console.WriteLine("Rok: ");
                Console.WriteLine(rok);
                Console.WriteLine("jest przestępny");
            }
            else
                Console.WriteLine("Rok: ");
            Console.WriteLine(rok);
            Console.WriteLine("nie jest przestępny");
            Console.ReadKey();
        }
    }
