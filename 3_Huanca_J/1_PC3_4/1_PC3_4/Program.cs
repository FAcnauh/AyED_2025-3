using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
              Para poder cobrar la beca JuanPedro se debe cumplir
              con alguna de las siguientes condiciones... 
              1) ser mayor de 19 años y tener unos ingresos iguales o 
              inferiores a $100.000 mensuales
              2) ser menor de 19 y no poseer ingresos mensuales
              3) tener 19 años y poseer ingresos hasta $50.000 mensuales

              Escribir un programa que pregunte al usuario su edad y
              sus ingresos mensuales y muestre por pantalla si el 
              usuario puede cobrar o no.
             */

            int edad;
            int ing;
            int H;
            Console.WriteLine("edad:");
            edad = int.Parse(Console.ReadLine());
            H = 0;
            Console.WriteLine("ingresos mensuales:");
            ing = int.Parse(Console.ReadLine());

            if (edad > 19 && ing <= 100000)
            {
                H = H + 1;
            }

            if(edad < 19 && ing == 0)
            {
                H = H + 1;
            }

            if (edad == 19 && ing <= 50000)
            {
                H = H + 1;

            }

            if (H == 1)
            {

                Console.WriteLine("JuanPedro es aceptado a cobrar la beca");
            }
            else
            {
                Console.WriteLine("JuanPedro no califica para cobrar la beca");
            }

            Console.ReadKey();
        }
    }
}
