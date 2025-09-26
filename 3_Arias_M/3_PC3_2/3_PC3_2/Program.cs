using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC3_2
{
    class Program
    {
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        static int Restar(int a, int b)
        {
            return a - b;
        }

        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        static double Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: no se puede dividir por cero.");
                return 0;
            }
            else
            {
                return (double)a / b;
            }
        }

        static int PedirNumero(string mensaje)
        {
            int numero = 0;
            bool valido = false;

            while (!valido)
            {
                Console.Write(mensaje);
                string entrada = Console.ReadLine();

                try
                {
                    numero = int.Parse(entrada);
                    valido = true;
                }
                catch
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }

            return numero;
        }

        static void Calculadora(int opcion, int num1, int num2)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Resultado: " + Sumar(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + Restar(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + Multiplicar(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("Resultado: " + Dividir(num1, num2));
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la operación:");
            Console.WriteLine("1 - Sumar");
            Console.WriteLine("2 - Restar");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");

            int opcion = PedirNumero("Ingrese opción (1 a 4): ");

            while (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción inválida. Intente de nuevo.");
                opcion = PedirNumero("Ingrese opción (1 a 4): ");
            }

            int num1 = PedirNumero("Ingrese el primer número: ");
            int num2 = PedirNumero("Ingrese el segundo número: ");

            Calculadora(opcion, num1, num2);

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}