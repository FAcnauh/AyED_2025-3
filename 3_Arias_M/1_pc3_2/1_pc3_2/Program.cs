using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa que pida al usuario dos números y muestre por pantalla su división.
             Si el divisor es cero el programa debe mostrar un error.
             */
            double num1;
            double num2;
            double numf;

            Console.WriteLine("numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 1 es " + num1);

            Console.WriteLine("numero 2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2 es " + num2);

            if (num2 == 0)
            {
                Console.WriteLine("ERROR: no se puede dividir por cero");
            }
            else
            {
                numf = num1 / num2;
                Console.WriteLine("resultado de la division es: " + numf);
            }


            Console.ReadKey();

        }
    }
}
