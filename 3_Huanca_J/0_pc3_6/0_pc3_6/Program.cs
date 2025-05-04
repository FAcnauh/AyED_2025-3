using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc3_6
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Escribe un programa en C# que calcule el resultado de multiplicar dos números introducidos por el usuario.
             */

            int num1;
            int num2;
            int numf;


            Console.WriteLine("numero 1:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 1 es " + num1);


            Console.WriteLine("numero 2:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2 es " + num2);

            numf = num1 * num2;

            Console.WriteLine("resultado de la multiplicacion es: " + numf);

            Console.ReadKey();


        }
    }
}
