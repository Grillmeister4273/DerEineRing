using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Zahlen
    {
        public static void Start()
        {
            Console.WriteLine("Hallo! Geben Sie eine Zahl ein: ");
            int zahl = Convert.ToInt32(Console.ReadLine());
            if (zahl % 2 == 0)
            {
                Console.WriteLine("Die Zahl ist gerade");
            }
            else { Console.WriteLine("Die Zahl ist ungerade"); }

            if (zahl > 100)
            {
                Console.WriteLine("die Zahl ist größer als 100");
            }
            else { Console.WriteLine("die Zahl ist kleiner als 100"); }

            if (zahl % 7 == 0)
            {
                Console.WriteLine("die Zahl ist durch 7 teilbar");
            }
            else { Console.WriteLine("die Zahl ist nicht durch 7 teilbar"); }
            if (zahl >= 100)
            {
                Console.WriteLine("Die Zahl hat 3 Stellen oder mehr");
            }
            else { Console.WriteLine("Die Zahl hat weniger als 3 Stellen"); }


            bool x1 = true; bool x2 = false;

            Console.WriteLine((x1 && x2));
            Console.WriteLine(!(x1 || x2));
            Console.WriteLine((!x1 && !x2));
            Console.WriteLine((x1 || x2) && (!x1 && x1));

            Console.WriteLine("Welches Jahr soll überprüft werden?");
            int jahr = Convert.ToInt32(Console.ReadLine());

            if (jahr % 4 == 0)
            {


                if (jahr % 100 != jahr % 400)
                {
                    Console.WriteLine(jahr + " ist ein Schaltjahr. ");

                }
            }
            else { Console.WriteLine(jahr + " ist kein Schaltjahr"); }
           


        }
    }
}
