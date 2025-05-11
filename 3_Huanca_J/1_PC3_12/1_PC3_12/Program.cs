using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriba un programa que pregunte una y otra vez si
            desea terminar el programa, salvo si se contesta exactamente
            SI (en mayúsculas y sin tilde).
            */

            string n;
            int g;
            g = 0;


            for (int i = 1; i == 1; g++)
            {
                Console.WriteLine("Para salir del programa coloque SI");
                n = Console.ReadLine();
                if (n == "SI")
                {
                    Console.WriteLine("Listo, toque cualquier letra para salir");
                    i = 0;
                }

                else
                {

                }


            }


            Console.ReadKey();

        }
    }
}