using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc3_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Escribe un programa en C# que calcule el resultado de dividr dos números introducidos por el usuario. 
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

            if (num2 == 0)
            {
                Console.WriteLine("no se puede dividir por cero");
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
