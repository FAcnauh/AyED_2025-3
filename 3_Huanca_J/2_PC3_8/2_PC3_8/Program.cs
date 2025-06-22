using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila;
            int columna;
            Console.WriteLine("Ingrese tamaño de fila");
            fila = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese tamaño de la columna");
            columna = int.Parse(Console.ReadLine());
            int[,] matriz = new int[fila, columna];

            for (int f = 0; f < fila; f++)
            {

                for (int c = 0; c < columna; c++)
                {

                    Console.WriteLine(matriz[f, c]);
                }
            }
            Console.ReadKey();

        }
    }
}