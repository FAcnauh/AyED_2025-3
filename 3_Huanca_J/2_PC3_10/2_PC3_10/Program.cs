using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila;
            int columna;
            Console.WriteLine("Ingrese tamaño de fila de las matrices");
            fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tamaño de la columna de las matrices");
            columna = int.Parse(Console.ReadLine());
            int[,] matriz1 = new int[fila, columna];
            int[,] matriz2 = new int[fila, columna];
            int[,] matriz3 = new int[fila, columna];
            Random rand = new Random();
            Console.WriteLine("Matriz 1: ");
            for (int f = 0; f < fila; f++)
            {
                Console.WriteLine("-------------------------------");
                for (int c = 0; c < columna; c++)
                {
                    int random = rand.Next(1, 100);
                    matriz1[f, c] = random;
                    Console.WriteLine(matriz1[f, c]);
                }
            }
            Console.WriteLine("Matriz 2: ");
            for (int a = 0; a < fila; a++)
            {
                Console.WriteLine("-------------------------------");
                for (int d = 0; d < columna; d++)
                {
                    int random = rand.Next(1, 100);
                    matriz2[a, d] = random;
                    Console.WriteLine(matriz2[a, d]);
                }
            }
            Console.WriteLine("Suma de las matrices 1 y 2: ");
            for (int a = 0; a < fila; a++)
            {
                Console.WriteLine("-------------------------------");
                for (int d = 0; d < columna; d++)
                {

                    matriz3[a, d] = matriz1[a, d] + matriz2[a, d];
                    
                    Console.WriteLine(matriz3[a, d]);
                }
            }
            Console.ReadKey();

        }
    }
}