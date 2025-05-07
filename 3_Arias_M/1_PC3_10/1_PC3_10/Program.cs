using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que muestre por consola(con un print) 
              los números de 1 a 100(ambos incluidos y con un salto de 
              línea entre  cada impresión), sustituyendo los siguientes:
             -Múltiplos de 3 por la palabra "fizz".

            - Múltiplos de 5 por la palabra "buzz".

            - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz".
            */


            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 1; i <= 100; i++)
            {
                a = 0;
                b = 0;
                c = 0;

                if (i % 3 == 0)
                {
                    a = 1;


                }

                if (i % 5 == 0)
                {
                    b = 1;
                    
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    c = 1;
                    Console.WriteLine( " fizzbuzz");
                }
                if (a == 1 && b == 0 && c == 0)
                {
                    Console.WriteLine( " fizz");
                }
                if (a == 0 && b == 1 && c == 0)
                {
                    Console.WriteLine( " buzz");
                }
                if (a == 0 && b == 0 && c == 1)
                {
                    Console.WriteLine("fizzbuzz");
                }
                if (a == 0 && b == 0 && c == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();

        }
    }
}