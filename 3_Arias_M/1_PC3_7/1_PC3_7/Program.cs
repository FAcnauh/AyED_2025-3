using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escribir un programa que pida al usuario una palabra y
             la muestre por pantalla 10 veces. 
             */
            string palabra;
            Console.WriteLine("escriba una palabra para mostrarla 10 veces");
            palabra = Console.ReadLine();


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("la palabra es " + palabra);
            }
            Console.ReadKey();
        }
    }
}
