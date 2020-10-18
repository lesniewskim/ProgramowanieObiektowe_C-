using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._9d
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0); // x jestr prawda dlatego reszta sie nie wykonuje
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
    }
}
