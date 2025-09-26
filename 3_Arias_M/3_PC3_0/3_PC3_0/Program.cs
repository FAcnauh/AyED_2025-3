using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC3_0
{
    class Program
    {
        static string Saludo(string nombre)
        {
            return "Hola " + nombre;
        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string nombreUsuario = Console.ReadLine();

            string mensaje = Saludo(nombreUsuario);
            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
    }
}