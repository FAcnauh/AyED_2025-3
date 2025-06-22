using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             En la empresa de videojuegos "Pixel Dreams", se está organizando un torneo en línea 
             de su juego más popular, "Galaxy Quest". Para determinar los ganadores, necesitan un programa 
             que ordene los puntajes de los jugadores de mayor a menor.
             El programa solicitará al usuario que ingrese la cantidad de participantes en el torneo.
             Luego, pedirá al usuario que ingrese los puntajes de cada participante, uno por uno.Una vez 
             ingresados todos los puntajes, el programa los ordenará de mayor a menor.Finalmente,
             mostrará la lista de puntajes ordenados, indicando el primer lugar (mayor puntaje) y 
             el último lugar (menor puntaje). 
             */
            int cantidadj;


            Console.WriteLine("Cantidad de jugadores: ");
            cantidadj = int.Parse(Console.ReadLine());
            int[] jugadores = new int[cantidadj];
            for (int u = 0; u <= cantidadj - 1; u++)
            {
                Console.WriteLine("puntaje jugador[" + u + "] = ");
                int usuario;

                usuario = int.Parse(Console.ReadLine());
                jugadores[u] = usuario;

            }

            for (int x = 0; x < cantidadj - 1; x++)
            {
                for (int k = 0; k < cantidadj - 1; k++)
                {

                    if (jugadores[k] < jugadores[k + 1])
                    {
                        int aux;
                        aux = jugadores[k];
                        jugadores[k] = jugadores[k + 1];
                        jugadores[k + 1] = aux;
                    }

                }
            }
            
            Console.WriteLine("Puntos De Jugadores");
            Console.WriteLine(jugadores[0]+ " MAYOR PUNTAJE");
            for (int i = 1; i <= cantidadj - 2; i++)
            {
                
                Console.WriteLine(jugadores[i]);

                

            }
            Console.WriteLine(jugadores[cantidadj-1] + " MENOR PUNTAJE");

            Console.ReadKey();
        }
    }
}
