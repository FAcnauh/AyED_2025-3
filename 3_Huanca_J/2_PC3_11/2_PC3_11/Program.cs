using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_11
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
            int[,] matriz = new int[fila, columna];
            
            Random rand = new Random();
            for (int a = 0; a < fila; a++)
            {
                Console.WriteLine("-------------------------------");
                for (int d = 0; d < columna; d++)
                {
                    int random = rand.Next(1, 100);
                    matriz[a, d] = random;
                    Console.WriteLine(matriz[a, d]);
                }
            }

            Console.WriteLine("Matriz a 90 grados: ");
            for (int a = 0; a < fila; a++)
            {
                Console.WriteLine("-------------------------------");
                for (int d = 0; d < columna; d++)
                {
                    
                    Console.WriteLine(matriz[d, a]);
                }
            }
            
            Console.ReadKey();

        }
    }
}
