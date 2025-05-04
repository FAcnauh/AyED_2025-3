using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Pedir al usuario que ingrese la temperatura 
             en grados Celsius. Según el valor, informar:

             Si es menor o igual a 0 → "Se congela"
             Si es mayor o igual a 100 → "Hierve"
             Si está entre 1 y 99 → "Está en estado líquido" 
             */

            float grados;

            Console.WriteLine("temperatura en grados celsius C°:");
            grados = float.Parse(Console.ReadLine());


            if (grados <= 0)

            {
                Console.WriteLine("Se congela");
            }


            if (grados >= 100)

            {
                Console.WriteLine("Hierve");
            }

            if (grados >= 1 && grados <= 99)

            {
                Console.WriteLine("Esta en estado liquido");
            }

            Console.ReadKey();
        }
    }
}
