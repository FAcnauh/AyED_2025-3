using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC3_1
{
    class Program
    {
        static int Suma(int a, int b) // función que devuelve un int
        {
            return a + b; // devuelve el resultado
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = Suma(num1, num2);

            Console.WriteLine("La suma es: " + resultado);
            Console.ReadKey();
        }
    }
}