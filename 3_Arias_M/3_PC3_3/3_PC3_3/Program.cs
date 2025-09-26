using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC3_3
{
    class Program
    {
        static int maxEncargos = 25;
        static string[,] encargos = new string[5, maxEncargos];
        static int contador = 0;

        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.Clear();
                MostrarMenu();
                string opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        CrearEncargo();
                        break;
                    case "2":
                        MostrarTodos();
                        break;
                    case "3":
                        AsignarCamion();
                        break;
                    case "4":
                        MostrarAsignados();
                        break;
                    case "5":
                        PromedioPorSede();
                        break;
                    case "6":
                        EncargoMayorDistancia();
                        break;
                    case "7":
                        FiltrarPorCodigoCamion();
                        break;
                    case "8":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Probá otra vez.");
                        Console.ReadKey();
                        break;
                }

            } while (!salir);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("===== MENÚ DE OPCIONES =====");
            Console.WriteLine("1. Crear nuevo encargo:");
            Console.WriteLine("2. Mostrar todos los encargos:");
            Console.WriteLine("3. Asignar camión a encargo:");
            Console.WriteLine("4. Mostrar todos los encargos asignados:");
            Console.WriteLine("5. Promedio de ganancia por sede:");
            Console.WriteLine("6. Mostrar el encargo con mayor distancia:");
            Console.WriteLine("7. Filtrar encargos por código de camión:");
            Console.WriteLine("8. Salir");
            Console.Write("Elegí una opción: ");
        }

        static void CrearEncargo()
        {
            if (contador >= maxEncargos)
            {
                Console.WriteLine("Limite de encargos");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Distancia en Km");
            int distancia = int.Parse(Console.ReadLine());

            while (distancia < 0)
            {
                Console.WriteLine("La distancia no puede ser negativa...Es ilegal que los camiones circulen en reversa");
                Console.WriteLine("Distancia en Km");
                distancia = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sede: 1 = BSAS, 2 = BB, 3 = MDQ");
            string sede = Console.ReadLine();

            while (sede != "1" && sede != "2" && sede != "3")
            {
                Console.WriteLine("Elija una opción de las tres...");
                Console.WriteLine("Sede: 1 = BSAS, 2 = BB, 3 = MDQ");
                sede = Console.ReadLine();
            }

            Console.WriteLine("Ganancias en pesos Argentinos");
            int ganancias = int.Parse(Console.ReadLine());

            while (ganancias < 0)
            {
                Console.WriteLine("No se puede colocar dinero negativo...");
                Console.WriteLine("Ganancias en pesos Argentinos");
                ganancias = int.Parse(Console.ReadLine());
            }

            encargos[0, contador] = "0";
            encargos[1, contador] = distancia.ToString();
            encargos[2, contador] = sede;
            encargos[3, contador] = ganancias.ToString();
            encargos[4, contador] = "0";

            contador++;
        }

        static void MostrarTodos()
        {
            Console.WriteLine("cod camion | distancia | Sede | Ganancias| Asignado");

            for (int i = 0; i < contador; i++)
            {
                Console.Write(encargos[0, i] + " | ");
                Console.Write(encargos[1, i] + " | ");
                Console.Write(encargos[2, i] + " | ");
                Console.Write(encargos[3, i] + " | ");
                Console.WriteLine(encargos[4, i]);
            }

            Console.ReadKey();
        }

        static void AsignarCamion()
        {
            Console.WriteLine("cod camion | distancia | Sede | Ganancias| Asignado");

            for (int i = 0; i < contador; i++)
            {
                if (encargos[4, i] == "0")
                {
                    Console.Write(encargos[0, i] + " | ");
                    Console.Write(encargos[1, i] + " | ");
                    Console.Write(encargos[2, i] + " | ");
                    Console.Write(encargos[3, i] + " | ");
                    Console.WriteLine(encargos[4, i]);
                }
            }

            Console.WriteLine("Elija el número de encargo 1/" + contador);
            int coordenada = int.Parse(Console.ReadLine());

            while (encargos[4, coordenada - 1] == "1")
            {
                Console.WriteLine("El encargo ya está asignado, elegí otro...");
                coordenada = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Indicar si el encargo será asignado (1 = Sí, 0 = No):");
            string valor = Console.ReadLine();
            encargos[4, coordenada - 1] = valor;

            Console.WriteLine("Indicar código camión:");
            string codigo = Console.ReadLine();
            encargos[0, coordenada - 1] = codigo;
        }

        static void MostrarAsignados()
        {
            Console.WriteLine("cod camion | distancia | Sede | Ganancias| Asignado");

            for (int i = 0; i < contador; i++)
            {
                if (encargos[4, i] == "1")
                {
                    Console.Write(encargos[0, i] + " | ");
                    Console.Write(encargos[1, i] + " | ");
                    Console.Write(encargos[2, i] + " | ");
                    Console.Write(encargos[3, i] + " | ");
                    Console.WriteLine(encargos[4, i]);
                }
            }

            Console.ReadKey();
        }

        static void PromedioPorSede()
        {
            Console.WriteLine("Coloque la sede para buscar su promedio de ganancias:");
            string sede = Console.ReadLine();
            int suma = 0;
            int cantidad = 0;

            for (int i = 0; i < contador; i++)
            {
                if (encargos[2, i] == sede)
                {
                    suma += int.Parse(encargos[3, i]);
                    cantidad++;
                }
            }

            if (cantidad > 0)
            {
                int promedio = suma / cantidad;
                Console.WriteLine("El promedio de ganancia de la sede " + sede + " es: " + promedio);
            }
            else
            {
                Console.WriteLine("No hay encargos para esa sede.");
            }

            Console.ReadLine();
        }

        static void EncargoMayorDistancia()
        {
            int max = int.Parse(encargos[1, 0]);

            for (int i = 1; i < contador; i++)
            {
                int dist = int.Parse(encargos[1, i]);
                if (dist > max)
                {
                    max = dist;
                }
            }

            Console.WriteLine("Encargo/s con mayor distancia (" + max + " km):");

            for (int i = 0; i < contador; i++)
            {
                if (int.Parse(encargos[1, i]) == max)
                {
                    Console.Write(encargos[0, i] + " | ");
                    Console.Write(encargos[1, i] + " | ");
                    Console.Write(encargos[2, i] + " | ");
                    Console.Write(encargos[3, i] + " | ");
                    Console.WriteLine(encargos[4, i]);
                }
            }

            Console.ReadKey();
        }

        static void FiltrarPorCodigoCamion()
        {
            Console.WriteLine("Escriba el código del camión:");
            string codigo = Console.ReadLine();
            Console.WriteLine("cod camion | distancia | Sede | Ganancias| Asignado");

            for (int i = 0; i < contador; i++)
            {
                if (encargos[0, i] == codigo)
                {
                    Console.Write(encargos[0, i] + " | ");
                    Console.Write(encargos[1, i] + " | ");
                    Console.Write(encargos[2, i] + " | ");
                    Console.Write(encargos[3, i] + " | ");
                    Console.WriteLine(encargos[4, i]);
                }
            }

            Console.ReadLine();
        }
    }
}