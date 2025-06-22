using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            
            Lilo está organizando una fiesta para los aliens invitados por Stitch y necesita gestionar la cantidad
            de comida necesaria. Para ello, ha creado un programa en C# que le ayudará a calcular el promedio
            de comida que necesitará por invitado. El programa solicitará al usuario que ingrese la cantidad
            de invitados y luego pedirá la cantidad de comida que cada invitado consume, asegurándose de que los
            valores ingresados estén dentro del rango permitido (de 1 a 100). Una vez que se hayan ingresado
            todos los datos, el programa calculará el promedio de comida por invitado y lo mostrará en pantalla. 
             
            */
            int resultado = 0;
            int promediofinal = 0;
            Random rand = new Random();
            Console.WriteLine("Coloque la cantidad de invitados");
            int invitados;
            invitados = int.Parse(Console.ReadLine());
            int[] miVector = new int[invitados];

            for (int i = 0; i <= invitados-1; i++)
            {
                miVector[i]= rand.Next(1, 100);
                Console.WriteLine("invitado ["+i+ "] = "+ miVector[i]);
                
                resultado = resultado + miVector[i];

            }
            promediofinal = resultado / invitados;
            Console.WriteLine("el promedio de comida es de " + promediofinal + " por invitado");
            Console.ReadKey();
        }
    }
}
