using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Después de unas largas vacaciones llenas de aventuras, Phineas y Ferb regresan a la escuela. Sin embargo, 
             como no estudiaron durante las vacaciones, necesitan un sistema que les ayude a determinar si podrán aprobar 
             la materia.
             El sistema debe permitir a Phineas y Ferb ingresar la cantidad de trabajos prácticos (TPs) y exámenes 
             que tienen en la materia. Luego, deben ingresar las notas de cada TP y examen.
             Para aprobar la materia, Phineas y Ferb deben cumplir dos condiciones:
             El promedio de las notas de los exámenes debe ser mayor o igual a 6.
             Al menos el 75% de los TPs deben tener una nota igual o mayor a 6.
             El sistema debe calcular el promedio de los exámenes y verificar si se cumplen las condiciones para aprobar 
             la materia. Finalmente, debe mostrar en pantalla un mensaje indicando si Phineas y Ferb pueden aprobar la 
             materia o no.
             Permitir al usuario especificar la cantidad de TPs y exámenes.
             Permitir al usuario ingresar las notas de cada TP y examen.
             Calcular el promedio de las notas de los exámenes.
             Verificar si se cumplen las condiciones para aprobar la materia.
             Mostrar un mensaje indicando si Phineas y Ferb pueden aprobar la materia. 
             */
            int aprobacion2 = 0;
            double porcentajetp = 0;
            int aprobacion=0;
            int cantidadex;
            Console.WriteLine("Cantidad de examenes: ");
            cantidadex = int.Parse(Console.ReadLine());
            int cantidadtp;
            Console.WriteLine("Cantidad de tps: ");
            cantidadtp = int.Parse(Console.ReadLine());
            int[] examen = new int[cantidadex];
            int[] tp = new int[cantidadtp];
            int contatp = 0;
            int contaex = 0;
            for (int i = 0; i <= cantidadex - 1; i++)
            {
                Console.WriteLine("Nota Examen[" + i + "] = ");
                int usuarioex;

                usuarioex = int.Parse(Console.ReadLine());
                examen[i] = usuarioex;
                contaex = contaex + usuarioex;


            }
            for (int u = 0; u <= cantidadtp - 1; u++)
            {
                Console.WriteLine("Nota TP[" + u + "] = ");
                int usuariotp;

                usuariotp = int.Parse(Console.ReadLine());
                tp[u] = usuariotp;
                if (tp[u] >=6)
                {
                    contatp = contatp + 1;
                }
                porcentajetp = porcentajetp + tp[u];
            
            }
            double calculo = 0.75;
            double apruebatp = 0;
            apruebatp = cantidadtp * calculo;
            if (contatp >= apruebatp)
            {

                Console.WriteLine("Aprobas los tps");
                
                aprobacion = 1;
            }

            else
            {
                Console.WriteLine("no aprobas los tps");
                
            }
            double promedioexamen;
            promedioexamen = contaex / cantidadex;
            if (promedioexamen >= 6)
            {
                Console.WriteLine("Aprobas el/los examen/es");
                
                aprobacion2 = 1;
            }
            else
            {
                Console.WriteLine("no Aprobas el/los examen/es");
            }
            if (aprobacion + aprobacion2 == 2)
            {
                Console.WriteLine("pasas la materia");
            } 
            else
            {
                Console.WriteLine("no pasas la materia");
            }
            Console.ReadKey();
        }
    }
}
