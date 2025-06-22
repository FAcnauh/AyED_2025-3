using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Durante el evento de ventas "Hot Sale", una tienda en línea 
             desea conocer cuál fue el producto más caro y el más 
             económico que se vendió durante el evento.

             El programa solicitará al usuario que ingrese la cantidad 
             de productos vendidos durante el Hot Sale. Luego, 
             pedirá al usuario que ingrese el precio de cada producto, 
             uno por uno. Una vez ingresados todos los precios, 
             el programa determinará cuál fue el precio más alto y cuál 
             fue el precio más bajo. Finalmente, mostrará al usuario los 
             precios más alto y más bajo registrados durante el evento. 
             */

            int cantidadp;


            Console.WriteLine("Cantidad de productos vendidos: ");
            cantidadp = int.Parse(Console.ReadLine());
            int[] productos = new int[cantidadp];

            for (int u = 0; u <= cantidadp - 1; u++)
            {
                Console.WriteLine("precio producto[" + u + "] = ");
                int preciop;

                preciop = int.Parse(Console.ReadLine());
                productos[u] = preciop;

            }

            for (int x = 0; x < cantidadp - 1; x++)
            {
                for (int k = 0; k < cantidadp - 1; k++)
                {

                    if (productos[k] < productos[k + 1])
                    {
                        int aux;
                        aux = productos[k];
                        productos[k] = productos[k + 1];
                        productos[k + 1] = aux;
                    }

                }
            }

            Console.WriteLine("lista de precios");
            Console.WriteLine(productos[0] + " MAYOR PRECIO");
            for (int i = 1; i <= cantidadp - 2; i++)
            {

                Console.WriteLine(productos[i]);



            }
            Console.WriteLine(productos[cantidadp - 1] + " MENOR PRECIO");

            Console.ReadKey();

        }
    }
}
