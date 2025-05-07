using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa que pregunte al usuario su edad
             y muestre por pantalla todos los 
             años que ha cumplido (desde 1 hasta su edad). 
             */

            int edad;
            

            Console.WriteLine("ingrese su edad");
            edad = int.Parse(Console.ReadLine());

            for (int i = 1; i <= edad; i++)
            {
                
                Console.WriteLine("años que haz cumplido " + i );
            }
        
             Console.ReadKey();
        }
    }
}
