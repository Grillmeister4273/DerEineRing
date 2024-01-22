using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Flächenberechnung
    {
        public static void Start()
        {
            Console.WriteLine("Welche Fläche wollen Sie berechnen?");
            Console.WriteLine("Tippen Sie eine 1 für ein Rechteck, eine 2 für ein Dreieck und eine 3 für einen Kreis.");
            int auswahl = 0;
            if (int.TryParse(Console.ReadLine(), out auswahl))
            {
                if (auswahl == 1)
                {
                    Console.Write("was ist a?   a=");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("was ist b?   b=");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Die Fläche des Rechteckes beträgt: " +a +"*"+b +"=" +a*b);
                }
            if (auswahl == 2)
                {
                    Console.Write("Was ist g?   g=");
                    int g = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Was ist h?   h=");
                    int h = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ie Fläche des Dreiecks beträgt: 1/2+'*");
                }
            if (auswahl == 3)
                {
                    Console.Write("Was ist r?   r=");
                    int r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Die Fläche des Kreises beträgt: π*" + r + "*" + r + "=" + r * r + 3.14);
                }
            }
            
        }

    }
}
