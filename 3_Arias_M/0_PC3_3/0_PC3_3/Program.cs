using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_PC3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            TP 3 - Etapa 0
            Desarrollar un codigo en el que almacenemos el nombre en una variable "nombre" y la edad en la variable "edad"
            Los datos deben ser ingresados por el usuario
            Finalmente debe saludar "Hola NOMBRE, tu edad es EDAD".
            */

            //Declaramos las variables
            string nombre;
            int edad;

            //UI - User Interface (Interfaz de Usuario)
            Console.Write("¿cual es tu nombre? ");

            //Instancia el usuario

            nombre = Console.ReadLine();//Tomo el valor por consola y lo igualo en el nombre
            Console.WriteLine("Tu nombre es: " + nombre);

            Console.ReadKey();

            Console.Write("¿cual es tu edad? ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Hola " + nombre + " tu edad es: " + edad);
            /*
            string edadTexto;
            edadt]Texto = Console.ReadLine();

            int edad;
            */
            Console.ReadKey();

        }
    }
}
