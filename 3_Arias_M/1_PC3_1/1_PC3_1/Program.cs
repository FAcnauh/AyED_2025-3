using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Escribir un programa que almacene la cadena de caracteres contraseña en una variable, pregunte al usuario por la contraseña e imprima por pantalla si la contraseña introducida por el usuario coincide con la guardada en la variable sin tener en cuenta mayúsculas y minúsculas.
            LA CONTRASÑEA ES: "bar"
            */

            string contraseña;
            
            string contraseñaa;

            contraseña = "bar";
            

            Console.WriteLine("escribir contraseña:");
            contraseñaa = Console.ReadLine();

            if (contraseñaa == contraseña || contraseñaa == "BAR" || contraseñaa == "Bar" || contraseñaa == "BAr" || contraseñaa == "baR" || contraseñaa == "bAR" || contraseñaa == "BaR" || contraseñaa == "bAr")
                {
                    Console.WriteLine("contraseña correcta");
                }
           else
                {
                    Console.WriteLine("contraseña incorrecta:");
                }
            Console.ReadKey();
        }
    
    }
}
