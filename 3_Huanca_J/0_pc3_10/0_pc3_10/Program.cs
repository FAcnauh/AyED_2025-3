using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_pc3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            La escala Celsius es centígrada, 100 divisiones separan el punto de congelación del punto de ebullición del agua. En la escala Fahrenheit de los anglosajones, estos dos puntos están separados por 180 grados. La escala de Kelvin es una escala absoluta utilizada en ciencias.
            Cree un programa en C# para convertir de grados centígrados a Kelvin y Fahrenheit. Solicite al usuario la cantidad de grados centígrados para convertirlos
            */
            int b;
            double a;
            double h;
            Console.WriteLine("grado celsius: ");
            b = int.Parse(Console.ReadLine());
            a = (b * 1.8) + 32;

            h = b + 273.15;
            Console.WriteLine("Grados Celsius: " + b + " °C");

            Console.WriteLine("farenheit: " + a + " F");
            Console.WriteLine("kelvin: " + h + " K");

            Console.ReadKey();
        }
    }
}
