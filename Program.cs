using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jelszo
{
    internal class Program
    {
        public static string bekeres()
        {
            Console.WriteLine("Kérek egy jelszót: ");
            return Console.ReadLine();
        }

        public static void teszteles()
        {
            bool JoJelszo = false;
            string jelszo = "";

            while (!JoJelszo)
            {
                jelszo = bekeres();

                if (jelszo.Length < 8)
                {
                    Console.WriteLine("A jelszónak legalább 8 karakter hosszúnak kell lennie.");
                }
                else if (!jelszo.Any(char.IsDigit))
                {
                    Console.WriteLine("A jelszóban kell lennie legalább egy számnak.");
                }
                else if (!jelszo.Any(char.IsUpper))
                {
                    Console.WriteLine("A jelszóban kell lennie legalább egy nagybetűnek.");
                }
                else
                {
                    JoJelszo = true;
                    Console.WriteLine("Jelszó elfogadva!");
                }
            }
        }

        public static void Main(string[] args)
        {
            teszteles();
        }
    }
}
