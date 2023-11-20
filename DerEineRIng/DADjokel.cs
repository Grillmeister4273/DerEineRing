using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class DADjokel
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein");
            string myzahl = Console.ReadLine();
            int zahl = 0;
            bool b7 = int.TryParse(myzahl, out zahl);
            if (b7 == false) { Console.WriteLine("Die Eingabe ist keine Zahl! "); }
            else
            {
                if (zahl <= 10 && zahl > 20) { Console.WriteLine(" Die eingegebene Zahl ist im Bereich zwischen 10 und 20. "); }
                else { Console.WriteLine("Die eingegebene Zahl ist nicht im Bereich zwischen 10 und 20. "); }
            }
            Console.WriteLine("Bitte geben Sie die erste Zahl ein: ");
            int zahl1 = 0;
            int zahl2 = 0;
            int zahl3 = 0;
            string s1 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein: ");
            string s2 = Console.ReadLine();
            Console.WriteLine("Bitte geben Sie die dritte Zahl ein: ");
            string s3 = Console.ReadLine();
            bool b1 = int.TryParse(s1, out zahl1);
            bool b2 = int.TryParse(s2, out zahl2);
            bool b3 = int.TryParse(s3, out zahl3);

            if (b1 == false || b2 == false || b3 == false) { Console.WriteLine("Erneuter Versuch benötigt!"); }
            else
            {
                if (zahl1 == zahl2 || zahl2 == zahl3) { Console.WriteLine("Eine der Zahlen ist gleich groß "); }
                else if (zahl1 > zahl2 && zahl1 > zahl3) { Console.WriteLine(zahl1 + "ist die größte Zahl. "); }
                else if (zahl2 > zahl3) { Console.WriteLine(zahl2 + "ist die größte Zahl. "); }
                else { Console.WriteLine(zahl3 + "ist die größte Zahl. "); }
            }

        }

    }

}
