using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Escriba un programa en C# que solicite al usuario tres letras y los muestre al revés.
             */

            char a;
            char b;
            char c;

            Console.WriteLine("escribi la primera letra:");
            a = char.Parse(Console.ReadLine());

            Console.WriteLine("escribi la segunda letra:");
            b = char.Parse(Console.ReadLine());

            Console.WriteLine("escribi la tercera letra:");
            c = char.Parse(Console.ReadLine());

            Console.WriteLine("en orden " + a + b + c);

            Console.WriteLine("en orden inverso " + c + b + a);

            Console.ReadKey();
        }
    }
}