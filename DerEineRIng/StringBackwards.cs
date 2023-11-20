using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class StringBackwards
        {
           public static void Start()
            {
                // Eingabe der Wörter
                Console.WriteLine("Geben Sie fünf Wörter ein:");
                string[] wörter = new string[5];
                for (int i = 0; i < wörter.Length; i++)
                {
                    wörter[i] = Console.ReadLine();
                }

                // Umgekehrte Reihenfolge der Wörter
                for (int i = 0; i < wörter.Length / 2; i++)
                {
                    string temp = wörter[i];
                    wörter[i] = wörter[wörter.Length - 1 - i];
                    wörter[wörter.Length - 1 - i] = temp;
                }

                // Ausgabe der Wörter in umgekehrter Reihenfolge
                Console.WriteLine("Die Wörter in umgekehrter Reihenfolge sind:");
                for (int i = 0; i < wörter.Length; i++)
                {
                    Console.WriteLine(wörter[i]);
                }
            }
        }
    }
