using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przyklad2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            Console.WriteLine("Podaj imię: ");
            tekst = Console.ReadLine();
            tekst = "Cześć " + tekst;
            Console.WriteLine(tekst);
            Console.WriteLine(tekst.Length);
            Console.ReadKey();
        }
    }
}
