using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double waga, wzrost, bmi;
            Console.WriteLine("Podaj swoją wagę w kilogramach. ");
            waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach. ");
            wzrost = double.Parse(Console.ReadLine());
            bmi = waga / (wzrost * wzrost);
            Console.WriteLine("Twoje BMI wynosi: ");
            Console.WriteLine(bmi);
            if(bmi < 18.0)
            {
                Console.WriteLine("Masz niedowagę");
            }
            else if (bmi >= 18.5 && bmi <= 24.99)
            {
                Console.WriteLine("Wartość jest prawidłowa");

            }    
            else
            {
                Console.WriteLine("Masz nadwagę");
            }

            Console.ReadKey();
        }
    }
}
