using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    public class Komprimierte_Eingabe_
    {
     
            public static string Compress(string input)
            {
                
                var keys = new List<char> { 'W', 'A', 'S', 'D', '1', };

                // Erstelle einen StringBuilder, um die komprimierte Ausgabe zu speichern
                var compressed = new StringBuilder();

                // Gehe die Eingabezeichen durch
                for (int i = 0; i < input.Length; i++)
                {
                    // Erhöhe den Zähler für das aktuelle Zeichen
                    compressed.Append("%" + keys.IndexOf(input[i]) + "%");

                    // Wenn das nächste Zeichen gleich dem aktuellen Zeichen ist, erhöhe den Zähler
                    if (i < input.Length - 1 && input[i] == input[i + 1])
                    {
                        i++;
                    }
                }

                return compressed.ToString();
            }

            public static void Start()
            {
                // Teste das Programm
                var input = Console.ReadLine();
                var compressed = Compress(input);
                Console.WriteLine("Unkomprimierte Eingabe: " + input);
                Console.WriteLine("Komprimierte Eingabe: " + compressed);
            }
       
    }
}
