using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int h;
            h = 0;
            int fila;
            int columna;
            Console.WriteLine("Ingrese tamaño de fila de las matrices");
            fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tamaño de la columna de las matrices");
            columna = int.Parse(Console.ReadLine());
            int[] nombre = new int[fila];
            int[,] matriz = new int[fila, columna];

            Random rand = new Random();
            for (int a = 0; a < fila; a++)
            {
                h++;
                Console.WriteLine("-------------------------------");
                for (int d = 0; d < columna; d++)
                {
                    int random = rand.Next(1, 100);
                    matriz[a, d] = random;
                    Console.WriteLine(matriz[a, d]);
                    
                }
                nombre[a] = matriz[a, a];
                if (h == columna)
                {
                    Console.WriteLine("Diagonal de la matriz: ");
                    for (int d = 0; d < fila; d++)
                    {

                        Console.WriteLine(nombre[d]);
                    }
                }
            }
            

                



            Console.ReadKey();

        }
    }
}
