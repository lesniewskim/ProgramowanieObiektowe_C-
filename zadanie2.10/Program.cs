using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = (double)osoby / powierzchnia; //wystarczy dodac do przed jedna z  zmiennych w nawiasie(double) i uzyskamy wynik po przecinku
            Console.WriteLine(gestoscZaludnienia);
        }
    }
}
