using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
        class GleitkommazahlenBerechnung
    {
            public static void Start()
            {
            Console.WriteLine("Geben Sie die ersten fünf Gleitkommazahlen ein:");
            float[] ersteZahlen = new float[5];
            for (int i = 0; i < ersteZahlen.Length; i++)
            {
                float v = 0;
                float.TryParse(Console.ReadLine(), out v);
                ersteZahlen[i] = v;
            }

            // Eingabe der zweiten fünf Gleitkommazahlen
            Console.WriteLine("Geben Sie die zweiten fünf Gleitkommazahlen ein:");
            float[] zweiteZahlen = new float[5];
            for (int i = 0; i < zweiteZahlen.Length; i++)
            {
                zweiteZahlen[i] = float.Parse(Console.ReadLine());
            }

            // Berechnung der Ergebnisse
            float summe = ersteZahlen[0] + zweiteZahlen[0];
            float differenz = ersteZahlen[1] - zweiteZahlen[1];
            float produkt = ersteZahlen[2] * zweiteZahlen[2];
            float quotient = ersteZahlen[3] / zweiteZahlen[3];
            bool gleich = ersteZahlen[4] == zweiteZahlen[4];

            // Ausgabe der Ergebnisse
            Console.WriteLine("Die Summe ist: {0}", summe);
            Console.WriteLine("Die Differenz ist: {0}", differenz);
            Console.WriteLine("Das Produkt ist: {0}", produkt);
            Console.WriteLine("Das Quotient ist: {0}", quotient);
            Console.WriteLine("Die Zahlen sind gleich: {0}", gleich);
        }
        }
    }
