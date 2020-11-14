using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Podaj a.");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj b");
            double b = Convert.ToDouble(Console.ReadLine());
            double wynik = 0;
            Console.WriteLine("Wybierz działanie");
            Console.WriteLine("1. Dodawanie");
            Console.WriteLine("2. Odejmowanie");
            Console.WriteLine("3. Mnożenie");
            Console.WriteLine("4. Dzielenie");

                double wybierz = double.Parse(Console.ReadLine());
                switch (wybierz)
                {
                    case 1:
                        {
                            wynik = a + b;
                            Console.WriteLine("Wynik to: ");
                        Console.WriteLine(wynik);
                            break;
                        }
                    case 2:
                        {
                            wynik = a - b;
                            Console.WriteLine("Wynik to: ");
                        Console.WriteLine(wynik);
                        break;
                        }
                    case 3:
                        {

                            wynik = a * b;
                            Console.WriteLine("Wynik to:");
                        Console.WriteLine(wynik);
                        break;
                        }
                    case 4:
                        {

                            wynik = a / b;
                            Console.WriteLine("Wynik to:  ");
                        Console.WriteLine(wynik);
                        break;
                        
                        }
                    default:
                        {
                            Console.WriteLine("Nie ma takiej opcji");
                            break;
                        }
                }
            Console.ReadKey();

            }
        }
}
