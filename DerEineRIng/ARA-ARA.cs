using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class ARA_ARA
    {
        public static void Start()
        {
            
            int zahl = 0;
            Random rnd = new Random();
            int z = rnd.Next(1, 8);
            Console.WriteLine("Bitte geben Sie eine Begrüßung ein: ");
            string ola = Console.ReadLine();
            ola.ToLower();

            bool zahlYN = int.TryParse(ola, out zahl);
            if (zahlYN == true)
            {
                Console.WriteLine("eine Begrüßung darf keine Zahlen beinhalten!");
            }
            switch (ola)
            {
                case "hallo":
                case "servus":
                case "grüß gott":
                case "guten tag":
                case "grüeziwohl":
                case "hey":
                case "moinsen":
                case "dere":
                    Console.WriteLine("*" + ola + "*" + " kenn ich. ");
                    break;




            }

        }
    }
}



