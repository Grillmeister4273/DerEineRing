using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Farben
    {
        public static void Start()
        {
            string rot = "rot";
            string blau = "blau";
            string gelb = "gelb";
            Console.WriteLine("Bitte geben Sie Farbe eine Farbe ein: ");
            string farbeeins = Console.ReadLine(); farbeeins = farbeeins.ToLower(); farbeeins = farbeeins.Trim();
            Console.WriteLine("Bitte geben Sie eine zweite Farbe ein: ");
            string farbezwei = Console.ReadLine(); farbezwei = farbezwei.ToLower(); farbezwei = farbezwei.Trim();

            Console.Clear();
            // while (farbeeins == "rot" || farbeeins == "blau" || farbeeins == "gelb")
            {
                if (farbeeins == farbezwei)
                {
                    if (farbeeins == rot)
                    {
                        Console.WriteLine("Die Farbe ist Rot. ");
                    }
                    else if (farbeeins == blau) { Console.WriteLine("Die Farbe ist Blau. "); }
                    else if (farbeeins == gelb) { Console.WriteLine("Die Farbe ist Gelb. "); }
                }
                else if (farbeeins != farbezwei)
                {
                    if (farbeeins == rot)
                    {
                        if (farbezwei == blau) { Console.WriteLine("Die Farbe ist Lila"); }
                        else if (farbezwei == gelb) { Console.WriteLine("Die Farbe ist Orange. "); }
                    }
                    if (farbeeins == blau)
                    {
                        if (farbezwei == gelb) { Console.WriteLine("Die Farbe ist Grün. "); }
                        else if (farbezwei == rot) { Console.WriteLine("Die Farbe ist Lila. "); }
                    }
                    if (farbeeins == gelb)
                    {
                        if (farbezwei == rot) { Console.WriteLine("Die Farbe ist Orange. "); }
                        else if (farbezwei == blau) { Console.WriteLine("Die Farbe ist Grün. "); }
                    }
                }

                if (farbeeins != rot) { Console.WriteLine("UNGÜLTIGE EINGABE! VERKACKT!"); }



            }
        }
    }
}