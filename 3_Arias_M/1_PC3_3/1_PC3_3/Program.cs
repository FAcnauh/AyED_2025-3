using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_3
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Escribir un programa que pida al usuario un número entero
             y muestre por pantalla si es par o impar. Y... ¿Si es 0? 
             */

            int num;


            Console.WriteLine("numero para saber si es par o impar:");
            num = int.Parse(Console.ReadLine());

             if (num % 2 == 0)
            {

                Console.WriteLine("el numero es par");

            }
            else
            {

                Console.WriteLine("el numero es impar:");

            }

            Console.ReadKey();


        }
    }
}
