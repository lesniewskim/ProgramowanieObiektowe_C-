using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace przyklad2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linia1\nLinia2"); // przejście do nowej linii
 Console.WriteLine("Wzrost 170\tWaga 65"); // \t - tabulacja
 Console.WriteLine(@"Wzrost 170\tWaga 65"); // @ - dosłowna interpretacja
 Console.WriteLine("C:\\Windows\\Temp"); // podwójny "\\" wstawia "\"
 Console.WriteLine("Tytuł filmu: \"Rój\""); // znak \" wstawia znak "
 Console.ReadKey();
        }
    }
}
