using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    class ZusatzaufgabeDez
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie ein Wort ein: ");
            string str1 = Console.ReadLine();
            for (int i = str1.Length - 1; i >= 0; i--)
            {

                Console.Write(str1[i]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Bitte geben Sie eine Zahl ein, suka ");

            int zahl = int.Parse(Console.ReadLine());


            bool istPrimzahl = true;
            for (int i = 2; i < zahl; i++)
            {
                if (zahl % i == 0)
                {
                    istPrimzahl = false;
                    break;
                }
            }
            if (istPrimzahl)
            {
                Console.WriteLine("Die Zahl " + zahl + " ist eine Primzahl.");
            }
            else
            {
                Console.WriteLine("Die Zahl " + zahl + " ist keine Primzahl.");
            }
        }
    }
}