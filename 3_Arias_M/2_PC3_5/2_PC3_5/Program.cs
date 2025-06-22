using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             La compañía de videojuegos "ZEGA" está desarrollando un nuevo
             juego de rol (RPG) en el que los jugadores pueden encontrar
             objetos con diferentes valores. Necesitan un programa que 
             permita identificar en qué posición se encuentran los 
             objetos cuyo valor es mayor a un número dado.

             El programa solicitará al usuario que ingrese la cantidad 
             de elementos (objetos) que desea analizar. Luego, pedirá al
             usuario que ingrese el valor mínimo que deben tener los 
             objetos para ser considerados en el filtro. Seguidamente, 
             el programa solicitará al usuario que ingrese los valores 
             de los objetos, uno por uno. Una vez ingresados todos los 
             valores, el programa mostrará al usuario las posiciones 
             en las que se encuentran los objetos cuyo valor es mayor al 
             número especificado. 
             */
           


                int cantidadp;


                Console.WriteLine("Cantidad de objetos: ");
                cantidadp = int.Parse(Console.ReadLine());
                int[] productos = new int[cantidadp];

                for (int u = 0; u <= cantidadp - 1; u++)
                {
                    Console.WriteLine("valor objeto numero[" + u + "] = ");
                    int preciop;

                    preciop = int.Parse(Console.ReadLine());
                    productos[u] = preciop;

                }
                Console.WriteLine("ingrese el valor mínimo que deben tener los objetos para ser considerados en el filtro");
                    int  minimo;

                    minimo = int.Parse(Console.ReadLine());
                
                Console.WriteLine("posiciones en las que se encuentran los objetos cuyo valor es mayor al número especificado.");
                
                for (int i = 0; i <= cantidadp - 1; i++)
                {

                    if (productos[i] > minimo)
                {
                    Console.WriteLine("Posicion del objeto n°:" + i + " valor:" + productos[i]);


                }
                

                

                }
            Console.ReadKey();
        }
   }

}

