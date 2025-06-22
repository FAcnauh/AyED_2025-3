using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PC3_7
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             El objetivo de este ejercicio es crear un programa que utilice 
             un vector, números aleatorios generados con la función Random 
             y una estructura de control switch para realizar las 
             siguientes acciones:

             1)  Se crea un vector de tamaño n, donde n es un valor 
                 ingresado por el usuario.
             2)  Se utiliza la función Random para generar números 
                 aleatorios entre un rango definido y se llenan las 
                 posiciones del vector con estos valores.
             3)  Se presenta al usuario un menú con las siguientes opciones:
                 Imprime en pantalla todos los elementos del vector.
                 El usuario ingresa un número y el programa busca si este 
                 se encuentra en el vector. Si lo encuentra, se indica 
                 la posición en la que se encuentra.
                 Se ordena el vector de forma ascendente o descendente, 
                 según la elección del usuario.
                 Termina la ejecución del programa.
                 El programa utiliza la estructura de control switch 
                 para evaluar la opción seleccionada por el usuario y 
                 ejecutar la acción correspondiente. 
             */
            int y;
            int n;
            int m;
            Random rand = new Random();


            Console.WriteLine("cantidad de elementos: ");
            n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];


            for (int u = 0; u <= n - 1; u++)
            {

                int random = rand.Next(1, 100);
                vector[u] = random;

            }

            Console.WriteLine("MENU-----------");
            Console.WriteLine("1-Imprimir en pantalla los elementos del vector");
            Console.WriteLine("2-Ingrese un número para averiguar si esta en el vector");
            Console.WriteLine("3-Ordenar de forma ascendente");
            Console.WriteLine("4-Ordenar de forma descendente");
            Console.WriteLine("6-Salir del programa");
            Console.WriteLine("seleccione una opcion: ");

            do
            {

                y = int.Parse(Console.ReadLine());
                switch (y)
                {
                    case 1:
                        for (int u = 0; u <= n - 1; u++)
                        {
                            Console.WriteLine("Vector [" + u + "] = " + vector[u]);

                        }

                        Console.WriteLine("Presione la tecla 5 para regresar al Menu");
                        break;

                    case 2:

                        Console.WriteLine("Ingresa un número para encontrarlo en el vector: ");
                        m = int.Parse(Console.ReadLine());

                        int conta = 0;
                        int conta2 = 0;
                        for (int u = 0; u <= n - 1; u++)
                        {
                            if (vector[u] != m)
                            {
                                conta++;
                                
                            }
                            else
                            {
                                Console.WriteLine("El Vector Se encuentra en la posicion [" + u + "]");
                                conta2++;
                            }

                           
                            
                            

                        }
                        if (conta>=1 && conta2 <1)
                        {
                            Console.WriteLine("El número ingresado no se encuentra entre los elementos de mi vector");
                        }

                        Console.WriteLine("Presione la tecla 5 para regresar al Menu");

                        break;

                    case 3:
                        for (int x = 0; x < n - 1; x++)
                        {
                            for (int k = 0; k < n - 1; k++)
                            {

                                if (vector[k] < vector[k + 1])
                                {
                                    int aux;
                                    aux = vector[k];
                                    vector[k] = vector[k + 1];
                                    vector[k + 1] = aux;
                                }

                            }
                        }
                        for (int t = n - 1; t >= 0; t--)
                        {
                            Console.WriteLine("Vector[" + t + "] = " + vector[t]);


                        }
                        Console.WriteLine("Presione la tecla 5 para regresar al Menu");
                        break;

                    case 4:
                        for (int x = 0; x < n - 1; x++)
                        {
                            for (int k = 0; k < n - 1; k++)
                            {

                                if (vector[k] < vector[k + 1])
                                {
                                    int aux;
                                    aux = vector[k];
                                    vector[k] = vector[k + 1];
                                    vector[k + 1] = aux;
                                }

                            }
                        }
                        for (int u = 0; u <= n - 1; u++)
                        {
                            Console.WriteLine("Vector [" + u + "] = " + vector[u]);

                        }
                        Console.WriteLine("Presone la tecla 5 para regresar al Menu");
                        break;

                    case 5:
                        Console.WriteLine("MENU-----------");
                        Console.WriteLine("1-Imprimir en pantalla los elentos del vector");
                        Console.WriteLine("2-Ingrese un número para averiguar si esta en el vector");
                        Console.WriteLine("3-Ordenar de forma ascendente");
                        Console.WriteLine("4-Ordenar de forma descendente");
                        Console.WriteLine("6-Salir del programa");
                        Console.WriteLine("seleccione una opcion: ");
                        break;
                    case 6:
                        y = 6;
                        break;




                }

            } while (y != 6);
        }
    }
}