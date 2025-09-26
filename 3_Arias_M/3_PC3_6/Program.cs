using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC3_6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MINI BALATRO (versión simplificada) ===\n");

            string[] mano = mano_aleatoria();
            string tipo = tipo_de_mano(mano);
            int base_pts = puntaje_base(mano);
            double mult = multiplicador(tipo);
            double total = base_pts * mult;

            bool joker_x2 = true;
            bool joker_mas10 = true;
            total = aplicar_jokers(total, joker_x2, joker_mas10);

            mostrar_resumen(mano, tipo, base_pts, mult, total);

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        static string[] mano_aleatoria()
        {
            string[] rangos = { "A", "K", "Q", "J", "T", "9", "8", "7", "6", "5", "4", "3", "2" };
            string[] palos = { "H", "D", "C", "S" };
            Random random = new Random();
            string[] mano = new string[5];

            for (int i = 0; i < 5; i++)
            {
                int index_rango = random.Next(rangos.Length);
                int index_palo = random.Next(palos.Length);
                mano[i] = rangos[index_rango] + palos[index_palo];
            }

            return mano;
        }

        static string tipo_de_mano(string[] mano)
        {
            string[] rangos = new string[5];
            for (int i = 0; i < 5; i++)
            {
                char letra = mano[i][0];
                rangos[i] = letra.ToString();
            }

            string[] unicos = new string[5];
            int[] conteos = new int[5];
            int unicos_count = 0;

            for (int i = 0; i < 5; i++)
            {
                string actual = rangos[i];
                int pos = -1;
                for (int j = 0; j < unicos_count; j++)
                {
                    if (unicos[j] == actual)
                    {
                        pos = j;
                        break;
                    }
                }

                if (pos == -1)
                {
                    unicos[unicos_count] = actual;
                    conteos[unicos_count] = 1;
                    unicos_count++;
                }
                else
                {
                    conteos[pos]++;
                }
            }

            int max1 = 0;
            int max2 = 0;

            for (int i = 0; i < unicos_count; i++)
            {
                if (conteos[i] > max1)
                {
                    max2 = max1;
                    max1 = conteos[i];
                }
                else if (conteos[i] > max2)
                {
                    max2 = conteos[i];
                }
            }

            if (max1 == 4)
            {
                return "Poker";
            }
            else if (max1 == 3 && max2 == 2)
            {
                return "Full";
            }
            else if (max1 == 3)
            {
                return "Trio";
            }
            else if (max1 == 2)
            {
                return "Par";
            }
            else
            {
                return "Nada";
            }
        }

        static int puntaje_base(string[] mano)
        {
            int suma = 0;
            for (int i = 0; i < mano.Length; i++)
            {
                char letra = mano[i][0];
                int valor = valor_carta(letra);
                suma += valor;
            }
            return suma;
        }

        static int valor_carta(char rango)
        {
            if (rango == 'A')
            {
                return 14;
            }
            if (rango == 'K')
            {
                return 13;
            }
            if (rango == 'Q')
            {
                return 12;
            }
            if (rango == 'J')
            {
                return 11;
            }
            if (rango == 'T')
            {
                return 10;
            }
            if (rango == '9')
            {
                return 9;
            }
            if (rango == '8')
            {
                return 8;
            }
            if (rango == '7')
            {
                return 7;
            }
            if (rango == '6')
            {
                return 6;
            }
            if (rango == '5')
            {
                return 5;
            }
            if (rango == '4')
            {
                return 4;
            }
            if (rango == '3')
            {
                return 3;
            }
            if (rango == '2')
            {
                return 2;
            }
            return 0;
        }

        static double multiplicador(string tipo)
        {
            if (tipo == "Nada")
            {
                return 1.0;
            }
            if (tipo == "Par")
            {
                return 1.5;
            }
            if (tipo == "Trio")
            {
                return 2.5;
            }
            if (tipo == "Full")
            {
                return 3.5;
            }
            if (tipo == "Poker")
            {
                return 4.0;
            }
            return 1.0;
        }

        static double aplicar_jokers(double puntaje, bool x2, bool mas10)
        {
            if (x2)
            {
                puntaje *= 2;
            }
            if (mas10)
            {
                puntaje += 10;
            }
            return puntaje;
        }

        static void mostrar_resumen(string[] mano, string tipo, int base_pts, double mult, double total)
        {
            Console.Write("Mano: ");
            for (int i = 0; i < mano.Length; i++)
            {
                Console.Write("[" + mano[i] + "] ");
            }
            Console.WriteLine();
            Console.WriteLine("Tipo: " + tipo);
            Console.WriteLine("Puntaje base: " + base_pts);
            Console.WriteLine("Multiplicador: x" + mult);
            Console.WriteLine("Total (con Jokers): " + total);
        }
    }
}