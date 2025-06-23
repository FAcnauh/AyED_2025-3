using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int fila;
            Console.WriteLine("Ingrese tamaño de fila de la matriz");
            fila = int.Parse(Console.ReadLine());
            int[,] alumnos = new int[fila, 3];
            Random rand = new Random();
            
            
            
            
            for (int i = 0; i < fila; i++)
            {
                alumnos[i, 0] = i + 1; 
                alumnos[i, 1] = rand.Next(13, 18); 
                alumnos[i, 2] = rand.Next(1, 11); 
            }

           
            Console.WriteLine("Nro. Alumno   Edad   Nota");

            for (int i = 0; i < fila; i++)
            {
                Console.WriteLine(alumnos[i, 0] + "             " + alumnos[i, 1] + "       " + alumnos[i, 2]);
            }
            Console.ReadKey();
        }
    }
}