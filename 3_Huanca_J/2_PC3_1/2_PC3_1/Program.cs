using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            El Rayo McQueen está compitiendo en una carrera de alta velocidad. Necesita un programa en C# que 
            le ayude a registrar los tiempos de cada vuelta y calcular algunas estadísticas importantes. 

            El programa debe cumplir el siguiente orden:
            Permitir al Rayo McQueen ingresar los tiempos de cada vuelta de la carrera en segundos. Utiliza
            un array para almacenar estos tiempos.
            Calcular y mostrar en pantalla el tiempo total de la carrera.
            Calcular y mostrar en pantalla el promedio de tiempo por vuelta.
            Determinar y mostrar en pantalla cuál fue la mejor vuelta, es decir, la vuelta con el menor 
            tiempo registrado.
            El programa debe permitir al usuario ingresar la cantidad de vueltas que completó Rayo McQueen y
            luego ingresar los tiempos de cada vuelta. Al finalizar, mostrará las estadísticas calculadas.

            (Opcional: los tiempos se pueden ingresar automáticamente con
            un for y un Random... recordar nombreRandom.Next(10, 500) ).

            */
            
            
            int resultado = 0;
            int promediofinal = 0;
            Random rand = new Random();
            Console.WriteLine("cuantas vueltas tuvo la carrera?");
            int vueltas;
            vueltas = int.Parse(Console.ReadLine());
            int[] tiempos = new int[vueltas];
            for (int i = 0; i <= vueltas - 1; i++)
            {
                tiempos[i] = rand.Next(10, 500);
                Console.WriteLine("vuelta [" + i + "] = " + tiempos[i] + " segundos");

                resultado = resultado + tiempos[i];

            }
            promediofinal = resultado / vueltas;
            Console.WriteLine("el promedio de todas las vueltas es de " + promediofinal + " segundos");
            Console.WriteLine("tiempo total de la carrera: " + resultado + " segundos");
            Console.ReadKey();
            for (int x = 0; x < vueltas-1; x++)
            {
                for (int k = 0; k < vueltas - 1; k++)
                {

                    if (tiempos[k] < tiempos[k + 1])
                    {
                        int aux;
                        aux = tiempos[k];
                        tiempos[k] = tiempos[k + 1];
                        tiempos[k + 1] = aux;
                    }

                }
            }

            Console.WriteLine("tu mejor carrera fue de: "+ tiempos[vueltas-1]+ "segundos");
            Console.ReadKey();
        }
    }
}
