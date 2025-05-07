using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TP 2 - Etapa 0
            Desarrollar un codigo en el que amcenemos el nombre en una variable "nombre"y la edad en la variable "edad" Finalmente debe saludar "hola NOMBRE", tu edad es EDAD"
            */

            //Declaramos variables
            string nombre;
            int edad;

            //Instanciamos
            nombre = "Facundo Huanca";
            edad = 15;

            //Imprimimos
            Console.WriteLine("Hola" + nombre + " tu edad es: " + edad);

            Console.ReadLine();
        }
    }
}
