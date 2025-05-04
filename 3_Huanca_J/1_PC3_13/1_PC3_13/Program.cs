using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa en C# que presente un menú
             con diversas opciones simples y permita al usuario seleccionar 
             una de ellas.

             Descripción:
            Se solicita crear un programa en C# que muestre un menú con al
            menos tres opciones simples y permita al usuario seleccionar una 
            de ellas. Cada opción debe realizar una acción diferente, como
            mostrar un mensaje en pantalla o realizar un cálculo básico.

            Requerimientos:
            Mostrar un mensaje de bienvenida al programa.
            Presentar un menú con al menos tres opciones numeradas.
            Permitir al usuario seleccionar una opción ingresando 
            el número correspondiente.
            Realizar una acción diferente para cada opción seleccionada.
            Repetir el proceso hasta que el usuario elija una opción
            para salir del programa.
             */
            int n;
            int g;
            g = 0;

            Console.WriteLine("Bienvenido al menu!!");
            Console.WriteLine("1-Decir la hora");
            Console.WriteLine("2- Mandar un saludo");
            Console.WriteLine("3- Frase motivacional");
            Console.WriteLine("4- salir");

            for (int i = 1; i == 1; g++)
            {
                
                n = int.Parse(Console.ReadLine());
                if (n == 1)
                {
                    Console.WriteLine("la fecha y hora actual es: " + DateTime.Now);

                    Console.WriteLine("toca 5 para volver al menu");
                    n = int.Parse(Console.ReadLine());
                }

                else
                {

                }
                if (n == 2)
                {
                    string nombre;
                    Console.WriteLine("Cual es tu nombre?");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Hola "+ nombre + " que tengas un lindo dia");
                    Console.WriteLine("toca 5 para volver al menu");
                    n = int.Parse(Console.ReadLine());
                }
                if (n == 4)
                {
                    i = 0;
                   

                }
                if (n == 3)
                {
                    Console.WriteLine("El éxito no es un destino, es un viaje");
                    Console.WriteLine("toca 5 para volver al menu");
                    n = int.Parse(Console.ReadLine());

                }
                if (n == 5)
                {
                    Console.WriteLine("Bienvenido al menu!!");
                    Console.WriteLine("1-Decir la hora");
                    Console.WriteLine("2- Mandar un saludo");
                    Console.WriteLine("3- Frase motivacional");
                    Console.WriteLine("4- salir");
                    

                }


            }


            

        }

    }
}
