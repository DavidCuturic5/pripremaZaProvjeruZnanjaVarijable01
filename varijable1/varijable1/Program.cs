using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varijable1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5.0;
            double b = 2.0;
            double c = 4.3;
            double d = 7.8;

            double brojnik = Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2);
            double nazivnik = Math.Pow(a + b, 2) + Math.Pow(c + d,2);

            double x = (brojnik / nazivnik);

            Console.WriteLine($"Vrijednost izraza x je: {x}");

            Console.ReadKey();




        }
    }
}
