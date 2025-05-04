using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC3_5
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             El usuario debe ingresar si tiene comida (sí o no).
             un refugio (sí o no) y un bate (sí o no). 
             El prorama debe decir si sobrevive o no.



             Si tiene comida, refugio y un bate → sobrevive


             Si le falta algo → no sobrevive 
             */

            int H;
            string comida;
            string bate;
            string refugio;
            H = 0;
            Console.WriteLine("usted tiene comida? (si o no):");
            comida = Console.ReadLine();
            Console.WriteLine("usted tiene refugio? (si o no):");
            refugio = Console.ReadLine();
            Console.WriteLine("usted tiene un bate? (si o no):");
            bate = Console.ReadLine();
            
            if (comida == "si" || comida =="SI" || comida == "Si" || comida == "sI")
            {
                H=H+1;
            }

            if (refugio == "si" || refugio == "SI" || refugio == "Si" || refugio == "sI" )
            {
                H=H+1;
            }

            if (bate == "si" || bate == "SI" || bate == "Si" || bate == "sI" )
            {
                H=H+1;
            }

            if (H == 3)
            {
                Console.WriteLine("FELCIDADES SOBREVIVISTE");
            }

            else
            {
                Console.WriteLine("no sobrevives");
            }

            
            Console.ReadKey();

        }
    }
}
