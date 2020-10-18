using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._9f
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0); //wszystko jest prawda i wszystko sie wykonuje bo w obu dzialaniach jest bezwarunkowe lub
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

        }
    }
}
