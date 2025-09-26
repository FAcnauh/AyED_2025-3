using System;

class Program
{
    static string[] nombres = new string[20];
    static string[] sagas = new string[20];
    static int[] fuerzas = new int[20];
    static int[] defensas = new int[20];
    static bool[] esHeroe = new bool[20];
    static int cantidad = 0;

    static void Main()
    {
        int opcion;

        do
        {
            Console.Clear();
            Console.WriteLine("=== Borderlands MVM ===");
            Console.WriteLine("1. Nuevo Personaje");
            Console.WriteLine("2. Consultar Personaje por Nombre");
            Console.WriteLine("3. Modificar Personaje");
            Console.WriteLine("4. Eliminar Personaje");
            Console.WriteLine("5. Mostrar Todos los Personajes");
            Console.WriteLine("6. Salir");
            Console.Write("Ingrese opción: ");

            string opcionTexto = Console.ReadLine();

            while (!EsNumero(opcionTexto) || int.Parse(opcionTexto) < 1 || int.Parse(opcionTexto) > 6)
            {
                Console.Write("Opción inválida. Ingrese un número del 1 al 6: ");
                opcionTexto = Console.ReadLine();
            }

            opcion = int.Parse(opcionTexto);
            Console.Clear();

            if (opcion == 1) NuevoPersonaje();
            else if (opcion == 2) ConsultarPersonaje();
            else if (opcion == 3) ModificarPersonaje();
            else if (opcion == 4) EliminarPersonaje();
            else if (opcion == 5) MostrarPersonajes();

            if (opcion != 6)
            {
                Console.WriteLine("\nPresione ENTER para continuar...");
                Console.ReadLine();
            }

        } while (opcion != 6);
    }

    static void NuevoPersonaje()
    {
        if (cantidad >= 20)
        {
            Console.WriteLine("Ya hay 20 personajes. No se puede crear más.");
            return;
        }

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        // Validar nombre único
        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i] == nombre)
            {
                Console.WriteLine("Ese nombre ya existe.");
                return;
            }
        }

        Console.Write("Saga/Facción: ");
        string saga = Console.ReadLine();

        Console.Write("Fuerza (número): ");
        string fuerzaTexto = Console.ReadLine();
        while (!EsNumero(fuerzaTexto))
        {
            Console.Write("Valor inválido. Ingrese un número para la fuerza: ");
            fuerzaTexto = Console.ReadLine();
        }
        int fuerza = int.Parse(fuerzaTexto);

        Console.Write("Defensa (número): ");
        string defensaTexto = Console.ReadLine();
        while (!EsNumero(defensaTexto))
        {
            Console.Write("Valor inválido. Ingrese un número para la defensa: ");
            defensaTexto = Console.ReadLine();
        }
        int defensa = int.Parse(defensaTexto);

        Console.Write("¿Es héroe? (true/false): ");
        string heroeTexto = Console.ReadLine().ToLower();
        while (heroeTexto != "true" && heroeTexto != "false")
        {
            Console.Write("Valor inválido. Escriba 'true' o 'false': ");
            heroeTexto = Console.ReadLine().ToLower();
        }
        bool heroe = heroeTexto == "true";

        
        nombres[cantidad] = nombre;
        sagas[cantidad] = saga;
        fuerzas[cantidad] = fuerza;
        defensas[cantidad] = defensa;
        esHeroe[cantidad] = heroe;

        cantidad++;

        Console.WriteLine("Personaje creado correctamente.");
    }

    static void ConsultarPersonaje()
    {
        Console.Write("Nombre del personaje a buscar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i] == nombre)
            {
                MostrarDatos(i);
                return;
            }
        }

        Console.WriteLine("No se encontró ese personaje.");
    }

    static void ModificarPersonaje()
    {
        Console.Write("Nombre del personaje a modificar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i] == nombre)
            {
                Console.Write("Nueva fuerza (número): ");
                string fuerzaTexto = Console.ReadLine();
                while (!EsNumero(fuerzaTexto))
                {
                    Console.Write("Valor inválido. Ingrese un número para la fuerza: ");
                    fuerzaTexto = Console.ReadLine();
                }
                fuerzas[i] = int.Parse(fuerzaTexto);

                Console.Write("Nueva defensa (número): ");
                string defensaTexto = Console.ReadLine();
                while (!EsNumero(defensaTexto))
                {
                    Console.Write("Valor inválido. Ingrese un número para la defensa: ");
                    defensaTexto = Console.ReadLine();
                }
                defensas[i] = int.Parse(defensaTexto);

                Console.WriteLine("Personaje modificado.");
                return;
            }
        }

        Console.WriteLine("No se encontró ese personaje.");
    }

    static void EliminarPersonaje()
    {
        Console.Write("Nombre del personaje a eliminar: ");
        string nombre = Console.ReadLine();

        for (int i = 0; i < cantidad; i++)
        {
            if (nombres[i] == nombre)
            {
                // mover todos los personajes posteriores una posicion atras
                for (int j = i; j < cantidad - 1; j++)
                {
                    nombres[j] = nombres[j + 1];
                    sagas[j] = sagas[j + 1];
                    fuerzas[j] = fuerzas[j + 1];
                    defensas[j] = defensas[j + 1];
                    esHeroe[j] = esHeroe[j + 1];
                }
                cantidad--;
                Console.WriteLine("Personaje eliminado.");
                return;
            }
        }

        Console.WriteLine("No se encontró ese personaje.");
    }

    static void MostrarPersonajes()
    {
        if (cantidad == 0)
        {
            Console.WriteLine("No hay personajes para mostrar.");
            return;
        }

        // ACA CREA UN ARRAY PARA BUSCAR VECTORES
        string[] nombresOrdenados = new string[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            nombresOrdenados[i] = nombres[i];
        }

        Array.Sort(nombresOrdenados);

        for (int i = 0; i < cantidad; i++)
        {
            // aca se ordenann los nombres
            for (int j = 0; j < cantidad; j++)
            {
                if (nombres[j] == nombresOrdenados[i])
                {
                    MostrarDatos(j);
                    break;
                }
            }
        }
    }

    static void MostrarDatos(int i)
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Nombre: " + nombres[i]);
        Console.WriteLine("Saga/Facción: " + sagas[i]);
        Console.WriteLine("Fuerza: " + fuerzas[i]);
        Console.WriteLine("Defensa: " + defensas[i]);
        Console.WriteLine("¿Es héroe?: " + esHeroe[i]);
        Console.WriteLine("-----------------------------");
    }

    static bool EsNumero(string texto)
    {
        if (texto == null || texto.Length == 0)
        {
            return false;
        }
        
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] < '0' || texto[i] > '9')
            {
                return false;
            }
            
        }
        return true;
    }
}
