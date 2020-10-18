using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double BMI,waga;
            int wzrost;
            Console.Write("Obliczanie wskaznika BMI\n");
            Console.Write("Podaj wzrost w cm: ");
            wzrost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wage w kg: ");
            waga = double.Parse(Console.ReadLine());
            BMI = waga / wzrost;
            Console.WriteLine("wskaznik BMI wynosi: " + BMI);

            
        }
    }
}
