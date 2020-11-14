using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3._6b
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

            if (bmi < 16.0)
            {
                Console.WriteLine("Jesteś wygłodzony!");
            }
            else if (bmi >= 16.0 && bmi <= 16.99)
            {
                Console.WriteLine("Jesteś wychudzony!");
            }
            else if (bmi >= 17.0 && bmi <= 18.49)
            {
                Console.WriteLine("Masz niedowagę!");
            }
            else if (bmi >= 18.5 && bmi < +24.99)
            {
                Console.WriteLine("Mieścisz się w normie!");
            }
            else if (bmi >= 25 && bmi < +29.99)
            {
                Console.WriteLine("Masz nadwagę!");
            }
            else if (bmi >= 30.0 && bmi <= 34.99)
            {
                Console.WriteLine("Masz I stopień otyłości");
            }
            else if (bmi >= 35.0 && bmi <= 39.99)
            {
                Console.WriteLine("Masz II stopień otyłości(otyłość kliniczna)");
            }
            else if (bmi >= 40.0)
            {
                Console.WriteLine("Masz III stopień otyłości(otyłość skrajna)");
            }

            Console.ReadKey();
        }
    }
}
