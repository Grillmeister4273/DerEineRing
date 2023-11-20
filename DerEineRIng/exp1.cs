using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class exp1
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Magenta; //Ändert die Anzeigefarbe nach Magenta
            Console.WriteLine("Bitte den gewünschten Wert mit Null angeben");
            Console.ForegroundColor = ConsoleColor.White; //Ändert die Anzeigefarbe nach Weiß
            Console.WriteLine("Bitte geben Sie die Spannung ein: ");
            float spannung = float.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie den Wiederstand ein: ");
            float wiederstand = float.Parse(Console.ReadLine());
            Console.WriteLine("Bitte geben Sie die Stromstärke ein: ");
            float stromstarke = float.Parse(Console.ReadLine());

            while (spannung + wiederstand + stromstarke <= 0)
            {

            }

            if (spannung == 0)

            {
                float ergebnis = wiederstand * stromstarke;
                Console.WriteLine("Die Spannung beträgt: " + ergebnis + " V");
            }
            else if (wiederstand == 0)
            {
                float ergebnis = spannung / stromstarke;
                Console.WriteLine("Der Wiederstand beträgt: " + ergebnis + " (Ohm)");
            }
            else if (stromstarke == 0)
            {
                float ergebnis = spannung / wiederstand;
                Console.WriteLine("Die Stromstärke beträgt: " + ergebnis + " A");
            }
        }
    }
}