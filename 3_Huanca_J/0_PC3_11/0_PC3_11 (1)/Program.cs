using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double H;
            double o;
            int c;
            int b;
            Console.WriteLine("Ancho: ");

            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Alto:");
            c = int.Parse(Console.ReadLine());

            a = b * c;
            H = 2 * c + 2 * b;
            o = Math.Sqrt((b * b) + (c * c));

            Console.WriteLine("area: " + a);

            Console.WriteLine("perimetro: " + H );
            Console.WriteLine("Diagonal: " + o);
            Console.ReadKey();

        }
    }
}
