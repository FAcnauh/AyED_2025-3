using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_pc3_0
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Escribir un programa que pregunte al usuario su edad y muestre por pantalla si es mayor de edad o no.
             */

            int edad;
            Console.WriteLine("ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("eres mayor de edad");
            }
            
            else
            {
                Console.WriteLine("no eres mayor de edad");
            }
            Console.ReadKey();


        }
    }
}
