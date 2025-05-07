using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3__9
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Escribir un programa que pida al usuario un número entero 
             positivo y muestre por pantalla la cuenta atrás desde ese
             número hasta cero. 
             */

            int num;
            int num1;
            
            Console.WriteLine("ingrese la cuenta regresiva de un numero entero positivo:");
            
            num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {

                Console.WriteLine("el numero no es valido");
            }

            else
            {
                num1 = num;
                for (int i = 1; i <= num; i++)
                {
                    num1 = num1 - 1;

                    Console.WriteLine(num1);
                }
            }

            Console.ReadKey();
        }
    }
}
