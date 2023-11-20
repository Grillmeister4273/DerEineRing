using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Folie67
    {

        public static void Start()
        {
            int var1 = 160, var2 = 20, res = var1 + var2;

            string begrüßung = "Servus", ergebniss = "Do host dein Schmarn ";

            Console.WriteLine(begrüßung);
            Console.WriteLine(ergebniss + res);

            int res1 = (var1 / var2 / 2 * var2 - var1 + 3 * var2) % 27;
            Console.WriteLine(begrüßung);
            Console.WriteLine(ergebniss + res1);
            //Console.WriteLine("erwartet mich am fünften Tage, schaut nach Osten");

        }
    }
}
