using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc3_9
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Crea un programa en C# para calcular la superficie y el volumen de una esfera, dado su radio.
             (El radio lo deberá ingresar el usuario). 
             */

            int r;
            double s;
            double v;
            Console.WriteLine("Radio de la esfera:");
            r = int.Parse(Console.ReadLine());
            v = 1.3333333333333333* Math.PI * Math.Pow(r, 3);
            s = 4 * Math.PI * Math.Pow(r, 2);

            Console.WriteLine("Volumen es " + v);
            Console.WriteLine("superficie es " + s);

            Console.ReadKey();


        }
    }
}
