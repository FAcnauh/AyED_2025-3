using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC3_4_Level4Lite
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nivel 4 – Cifrado +1 (LITE)");
            string msg = "ctOS";
            string enc = Level4.CaesarPlusOne(msg);
            bool ok = enc == "duPT";
            Console.WriteLine(ok ? "✔ UNLOCK → Código final: CT-ACCESS-OK" : "🔒 LOCKED");

            Console.ReadKey();
        }
    }

    static class Level4
    {
        public static string CaesarPlusOne(string s)
        {
            string resultado = "";

            foreach (char c in s)
            {
                if (char.IsLower(c))
                {
                    if (c == 'z')
                        resultado += 'a';
                    else
                        resultado += (char)(c + 1);
                }
                else if (char.IsUpper(c))
                {
                    if (c == 'Z')
                        resultado += 'A';
                    else
                        resultado += (char)(c + 1);
                }
                else
                {
                    resultado += c;
                }
            }

            return resultado;
        }
    }
}