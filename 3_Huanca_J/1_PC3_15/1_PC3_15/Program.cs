using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _1_PC3_14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
        Simulá un juego donde el personaje está atrapado en una isla y debe sobrevivir
        durante 7 días. Cada día puede realizar distintas acciones, pero algunas tienen
        una probabilidad de tener consecuencias malas o buenas. Para esto, vas a
        utilizar números aleatorios ( Random ).
             */
            Console.WriteLine("Bienvenido, Seras capaz de sobrevivir 7 dias en la Isla? Colocate Un Nombre!!");
            string m;


            m = Console.ReadLine();
            
            int salud = 100;
            int hambre = 50;
            int energia = 70;
            int dia = 0;
            bool sigueVivo = true;
            Random rand = new Random();
            Console.WriteLine("=== LA ISLA ===");
            Console.WriteLine("Día "+ dia + " ¿Qué querés hacer?");
            Console.WriteLine("1. Buscar comida");
            Console.WriteLine("2. Dormir");
            Console.WriteLine("3. Explorar la isla");
            Console.WriteLine("4. Ver estado del personaje");
            Console.WriteLine("5. Salir del juego");
            
            int n;
       
            n = 0;
            
            
            

            while (n != 6 && sigueVivo == true)
            {
            if (dia<7)
            { 


                n = int.Parse(Console.ReadLine());
                    switch (n)
                    {


                        case 2:
                            Console.WriteLine("decides dormir");
                            energia = energia + 30;
                            hambre = hambre - 10;

                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                                sigueVivo = false;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("toca la tecla 7 para ir al menu");
                            }
                            dia = dia + 1;
                            break;
                        case 4:
                            Console.WriteLine("Nombre:" + m);
                            Console.WriteLine("Salud: " + salud);
                            Console.WriteLine("Hambre: " + hambre);
                            Console.WriteLine("Energia: " + energia);
                            Console.WriteLine("Dia: " + dia);
                            Console.WriteLine("toca la tecla 7 para ir al menu");
                            
                            break;
                        case 3:
                            Console.WriteLine("Decides explorar la isla!!");
                            energia = energia - 20;
                            hambre = hambre - 15;
                            int probabilidad2 = rand.Next(1, 101);
                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                                sigueVivo = false;
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No encontraste nada...");
                                Console.WriteLine("toca la tecla 7 para ir al menu");
                            }
                            dia = dia +1;
                            break;
                        case 1:
                            Console.WriteLine("Decides buscar comida en los rincones de la isla, y encuentras un par de bayas, no sabes si son venenosas, pero decides probar!!");
                            Console.WriteLine("toca cualquier letra para continuar");
                            Console.ReadKey();
                            hambre = hambre + 20;
                            energia = energia - 15;
                            int probabilidad = rand.Next(1, 101);
                            if (probabilidad <= 30)
                            {
                                salud = salud - 15;

                                Console.WriteLine("Comiste algo en mal estado. Salud -15.");
                                
                            }
                            if (salud <= 0 || hambre <= 0 || energia <= 0)
                            {
                                Console.WriteLine("Te desmayaste y no pudiste sobrevivir... Game Over");
                                sigueVivo = false;
                                Console.ReadKey();
                            }
                            else
                            {
                                if (probabilidad > 30)
                                {
                                    Console.WriteLine("Comiste algo en buen estado!!");
                                }
                                    Console.WriteLine("toca la tecla 7 para ir al menu");
                            }
                            dia = dia + 1;






                            break;




                        case 5:
                            n = 6;
                            break;
                        case 7:
                            Console.WriteLine("=== LA ISLA ===");
                            Console.WriteLine("Día " + dia + " ¿Qué querés hacer?");
                            Console.WriteLine("1. Buscar comida");
                            Console.WriteLine("2. Dormir");
                            Console.WriteLine("3. Explorar la isla");
                            Console.WriteLine("4. Ver estado del personaje");
                            Console.WriteLine("5. Salir del juego");
                            break;



                        default:
                            // Código si ningún caso coincide

                            break;



                    }
                }
                else
                {
                    Console.WriteLine("Felicidades, sobreviviste 7 dias");
                    Console.WriteLine("Toca cualquier tecla para salir del juego");
                    n = 6;
                    Console.ReadKey();
                }
            }

        }
    }
}