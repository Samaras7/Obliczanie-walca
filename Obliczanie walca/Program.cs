using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1._1
{
    class Program
    {
        static double Walec(double r, double h)
        {
            double V = Math.PI * r * r * h;
            return V;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj promień: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj wysokość: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Walec(r, h));
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
