using System;
using System.Collections.Generic;
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
             Vas a crear un menú con opciones para simular una pequeña historia gamer. El
            programa define al inicio del Main algunas variables que representan el estado del
            
            jugador. Cada opción del menú modifica o muestra estas variables.
             */
            Console.WriteLine("Bienvenido al Simulador Gamer, coloca un Nombre a Tu Guerrero!!");
            string m;
            
            
            m = Console.ReadLine();
            
            
            Console.WriteLine("=== SIMULADOR GAMER ===");
            Console.WriteLine("1.Mostrar estado del jugador");
            Console.WriteLine("2.Encontrar espada mágica");
            Console.WriteLine("3.Pelear contra un enemigo");
            Console.WriteLine("4.Comprar poción de vida (vale 30 monedas)");
            Console.WriteLine("5.Salir del juego");
            Console.WriteLine("Seleccione una opción: ");
            int enemigos_salud;
            int ataque_enemigos = 10;
            string teclas;
            string Vida_Extra;
            int n;
            enemigos_salud = 20;
            n = 0;
            string Jugador_compra;
            int monedas_x_dif = 0;
            string R_acertijo;
            int salud = 100;
            int monedas = 50;
            int enemigos_derrotados = 0;
            bool tieneEspada = false;
            bool pocion = false;
            int ataque_jugador = 0;
            
            while (n != 6 && salud >=0) 
            {

                
                n = int.Parse(Console.ReadLine());
                switch (n)
                {


                    case 4:
                        if (pocion == false)
                        { 
                            Console.WriteLine("Bienvenido A la Tienda!!");
                            Console.WriteLine("Para comprar Una Pocion (te Cura 60 de Salud!!) coloca la palabra si (OJO, solo en minusculas), si no toca 7 para volver al Menu!!");
                            Console.WriteLine("Costo = 30 monedas");
                            Jugador_compra = Console.ReadLine();
                            if (Jugador_compra == "si" && monedas >= 30 )
                            {
                                Console.WriteLine("Felicidades!!, Obtienes una Pocion de Salud!!");
                                Console.WriteLine("toca la tecla 7 para ir al menu");
                                pocion = true;
                                monedas = monedas - 30;

                            }
                            else
                            {
                                Console.WriteLine("No tienes suficientes monedas");
                                Console.WriteLine("toca la tecla 7 para ir al menu");
                            }
                            if (Jugador_compra == "7")
                            {
                                n = 7;
                            }
                            


                        }
                        else
                        {
                            Console.WriteLine("Ya tienes una Pocion!!, Solo se Permite Una por Batalla!!");
                            Console.WriteLine("toca la tecla 7 para ir al menu");
                        }
                            
                        break;
                    case 1:
                        Console.WriteLine("Nombre:" + m);
                        Console.WriteLine("Salud: " + salud);
                        Console.WriteLine("Monedas: " + monedas);
                        Console.WriteLine("Enemigos derrotados: " + enemigos_derrotados);
                        Console.WriteLine("Tiene Espada: " + tieneEspada);
                        Console.WriteLine("toca la tecla 7 para ir al menu");
                        break;
                    case 2:
                        if (tieneEspada == false)
                        {
                            Console.WriteLine("Visitas el Bosque Encantado, y te encuentras con un duende");
                            Console.WriteLine("Duende: Tengo una Espada de Obsidiana, si la quieres, debes resolver el siguiente Acertijo. Pero OJO, lo tenes que poner en minuscula");
                            Console.WriteLine("Vuelo sin alas, brillo sin sol, y cuando me ves… ¡pides un deseo, por favor!");
                            Console.WriteLine("Es una...");

                            R_acertijo = Console.ReadLine();
                            if (R_acertijo == "estrella fugaz")
                            {
                                Console.WriteLine("Felicidades!!, Obtienes la mega espada");
                                Console.WriteLine("Te desaces de la anterior");
                                Console.WriteLine("toca la tecla 7 para ir al menu");
                                tieneEspada = true;
                                
                            }
                            else
                            {
                                Console.WriteLine("incorrecto, toca la tecla 7 para ir al menu");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ya tienes una espada! con dos serias Invencible!!");
                            Console.WriteLine("toca la tecla 7 para ir al menu");
                        }    

                            break;
                    case 3:
                        Console.WriteLine("Caminas por el Peligroso Bosque, y Aparece un Enemigo detras de un Arbol!!");
                                    if (enemigos_derrotados <=9)
                                       {
                                       enemigos_salud = 25;
                                       
                                       monedas_x_dif = 5;
                                       Console.WriteLine("Estas en dificultad Super Mega Facil!! :DD");  
                                       }
                                    if (enemigos_derrotados >9 && enemigos_derrotados <=14)
                                       {
                                       enemigos_salud = 30;
                                       
                                       monedas_x_dif = 10;
                                       Console.WriteLine("Estas en dificultad Super Facil!! :D");
                                       }
                                    if (enemigos_derrotados > 14 && enemigos_derrotados <= 24)
                                       {
                                       enemigos_salud = 35;
                                       
                                       monedas_x_dif = 15;
                                       Console.WriteLine("Estas en dificultad Facil!! :)");
                                       }
                                    if (enemigos_derrotados > 24 && enemigos_derrotados <= 39 )
                                       {
                                       enemigos_salud = 50;
                                       
                                       monedas_x_dif = 20;
                                       Console.WriteLine("Estas en dificultad Normal!! :|");
                                       }
                                    if (enemigos_derrotados > 39 && enemigos_derrotados <= 59)
                                       {
                                       enemigos_salud = 60;
                                       
                                       monedas_x_dif = 25;
                                       Console.WriteLine("Estas en dificultad Dificil!! :(");
                                       }
                                    if (enemigos_derrotados > 59)
                                       {
                                       enemigos_salud = 100;
                                       
                                       monedas_x_dif = 30;
                                       
                                       Console.WriteLine("Estas en dificultad Ultra Dificil!! >:(");
                                       }
                                    while (enemigos_salud > 0 && salud > 0)
                                    { 
                                    if (enemigos_derrotados <=9)
                                       {
                                       
                                       ataque_enemigos = 15;
                                       
                                        
                                       }
                                    if (enemigos_derrotados >9 && enemigos_derrotados <=14)
                                       {
                                       
                                       ataque_enemigos = 15;
                                       
                                       }
                                    if (enemigos_derrotados > 14 && enemigos_derrotados <= 24)
                                       {
                                       
                                       ataque_enemigos = 20;
                                       
                                       }
                                    if (enemigos_derrotados > 24 && enemigos_derrotados <= 39 )
                                       {
                                       
                                       ataque_enemigos = 25;
                                       
                                       }
                                    if (enemigos_derrotados > 39 && enemigos_derrotados <= 59)
                                       {
                                       
                                       ataque_enemigos = 25;
                                       
                                       }
                                    if (enemigos_derrotados > 59)
                                       {
                                       
                                       ataque_enemigos = 35;
                                       
                                       }
                                        
                                        Console.WriteLine("Salud del enemigo: " + enemigos_salud);
                                        Console.WriteLine("Tu Salud: " + salud);
                                        Console.WriteLine("Atacar (a) ");
                                        
                                        Console.WriteLine("Escudo (e)");
                                        Console.WriteLine("Tomar Pocion (t)");
                                        teclas = Console.ReadLine();
                              
                                        if (teclas == "a")  
                                        {   
                                            ataque_jugador = 0;
                                            if (tieneEspada== true)
                                            {
                                            ataque_jugador = ataque_jugador + 35;
                            
                                            }    
                                            else
                                            {
                                            ataque_jugador = ataque_jugador + 20;
                                            
                                            }
                                            Console.WriteLine("Con Determinacion... Decides Atacar!! Le quitas -"+ ataque_jugador +" Al Enemigo!!");
                                            enemigos_salud = enemigos_salud - ataque_jugador;
                                            if (enemigos_salud > 0)
                                            {   
                                               Console.WriteLine("Le toca al enemigo toca cualquier tecla para continuar");
                                            
                                               Console.ReadLine();
                                               Console.WriteLine("El rival te ataca!! Pierdes -"+ataque_enemigos+" de Salud");
                                               salud =  salud - ataque_enemigos;
                                               
                                            }
                                            
                                        //El "}" de abajo pertenece al if correspondiente a las tecla "a"
                                        }
                                        if (teclas == "e")
                                        {
                                                Console.WriteLine("No te arriesgas... y Decides Usar Escudo!!");
                                                Console.WriteLine("Le toca al enemigo, toca cualquier tecla para continuar");
                                                ataque_enemigos = ataque_enemigos - 15;
                                                Console.ReadLine();
                                                Console.WriteLine("El rival te ataca!! Pierdes "+ataque_enemigos +" de Salud");
                                                Console.WriteLine("El Rival Esta Mareado por el Impacto Con el Escudo!!");
                                                Console.WriteLine("y entonces... Rapido!! Decides Atacar y le quitas 15 de salud al Enemigo!!");
                                                enemigos_salud = enemigos_salud - 15;
                                                salud = salud - ataque_enemigos;
                                        }
                                        if (teclas == "t")
                                        {
                                            if (pocion == true)
                                            {
                                                Console.WriteLine("Decides Tomar una Pocion!!, Obtienes mas 60 de Salud!!");
                                                salud = salud + 60;
                                                pocion = false;
                                                if (enemigos_salud > 0)
                                                {   
                                                Console.WriteLine("Le toca al enemigo toca cualquier tecla para continuar");
                                            
                                                Console.ReadLine();
                                                Console.WriteLine("El rival te ataca!! Pierdes -"+ataque_enemigos+" de Salud");
                                                salud =  salud - ataque_enemigos;
                                                
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Lamentablemente, No tienes Pocion :(");
                                                
                                            }
                                            
                                        
                                            
                                        }
                                        
                                    }           
                                    if (enemigos_salud <= 0)
                                    {
                                        Console.WriteLine("Felicidades!! Ganaste!! Derrotaste a tu Rival!!");
                                        Console.WriteLine("Obtienes " + monedas_x_dif + " Monedas!!");
                                        Console.WriteLine("toca 7 para volver al menu");
                                        enemigos_derrotados = enemigos_derrotados + 1;
                                        monedas = monedas + monedas_x_dif;
                                    }
                                    if (salud <= 0)
                                    {
                                    Console.WriteLine("Perdiste...");
                                    Console.WriteLine("Todo se Acabo");
                                    Console.WriteLine("Pero si hay algo dentro de TI que te permita continuar... Hazlo");
                                    Console.WriteLine("Para comprar una Vida Extra (300 monedas)... Coloca la palabra si. OJO en minusculas");
                                    Console.WriteLine("O sino, la palabra no (OJO en minusculas) para retirarte...");
                                    Vida_Extra = Console.ReadLine();
                                    if (Vida_Extra == "si" && monedas >= 300)
                                    {
                                        Console.WriteLine("Decides Aun no Dejar este Mundo... te pones de pie y Sigues por Tu Camino");
                                        Console.WriteLine("toca 7 para volver a la Aventura!!");
                                        monedas = monedas - 300;
                                        salud = 100;
                                    }
                                    else if (monedas < 300)
                                    {
                                        Console.WriteLine("Se acabo, no tienes suficientes monedas...Gracias por Jugar!!");
                                        Console.WriteLine("Adios...");
                                        n = 6;
                                        Console.ReadLine();
                                    }
                                    if (Vida_Extra == "no")
                                    {
                                        Console.WriteLine("Gracias por Jugar!!, Fue Divertido!!");
                                        Console.WriteLine("Adios... ");
                                        n = 6;
                                        Console.ReadLine();
                                    }
                                    }
                           break;
                        



                    case 5:
                        n = 6;
                            break;
                    case 7:
                        Console.WriteLine("=== SIMULADOR GAMER ===");
                        Console.WriteLine("1.Mostrar estado del jugador");
                        Console.WriteLine("2.Encontrar espada mágica");
                        Console.WriteLine("3.Pelear contra un enemigo");
                        Console.WriteLine("4.Comprar poción de vida (vale 30 monedas)");
                        Console.WriteLine("5.Salir del juego");
                        Console.WriteLine("Seleccione una opción: ");
                        break;

                    

                    default:
                        // Código si ningún caso coincide
                        
                        break;




                }
            }
            
        }
    }
}