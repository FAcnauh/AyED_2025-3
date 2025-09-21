using System;

class Program
{
    static void Main()
    {
        int hp_hornet = 10;
        int hp_max_hornet = 10;
        int atk_hornet = 3;
        int hp_enemigo = 12;

        Console.WriteLine("=== Hollow Knight: Simulador básico ===");

        while (hp_hornet > 0 && hp_enemigo > 0)
        {
            MostrarEstado(hp_hornet, hp_enemigo);

            Console.Write("\nAccion (atacar/curar/salir): ");

            string accion = Console.ReadLine();

            if (accion == "atacar")
            {
                hp_enemigo = Atacar(atk_hornet, hp_enemigo);
            }
            else if (accion == "curar")
            {
                hp_hornet = Curar(hp_hornet, hp_max_hornet);
            }
            else if (accion == "salir")
            {
                Console.WriteLine("\nBatalla interrumpida.");
                break;
            }
            else
            {
                Console.WriteLine("Accion no valida.");
            }

            if (hp_enemigo > 0)
            {
                hp_hornet -= 2;
                Console.WriteLine("El enemigo contraataca y hace 2 de dano!");
            }
        }

        Console.WriteLine("\n=== Resultado ===");

        if (hp_hornet <= 0) Console.WriteLine("Hornet ha caido...");
        else if (hp_enemigo <= 0) Console.WriteLine("¡Hornet gano!");
        else Console.WriteLine("Batalla finalizada.");

        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static int Atacar(int atk, int hp_enemigo)
    {
        int nuevo_hp = hp_enemigo - atk;
        if (nuevo_hp < 0) nuevo_hp = 0;
        return nuevo_hp;
    }

    static int Curar(int hp_hornet, int hp_max_hornet)
    {
        int nuevo_hp = hp_hornet + 5;
        if (nuevo_hp > hp_max_hornet) nuevo_hp = hp_max_hornet;
        return nuevo_hp;
    }

    static void MostrarEstado(int hp_hornet, int hp_enemigo)
    {
        Console.WriteLine("Hornet HP: " + hp_hornet + " | Enemigo HP: " + hp_enemigo);
    }
}