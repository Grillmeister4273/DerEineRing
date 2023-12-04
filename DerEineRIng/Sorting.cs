using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Sorting
    {
       public static void Start()
        {
            // Eingabe der Arraygröße
            Console.WriteLine("Geben Sie die Arraygröße ein: ");
            int arrayGroesse = Convert.ToInt32(Console.ReadLine());

            // Erstellen der Arrays
            int[] array = new int[arrayGroesse];
            int[] geradeZahlen = new int[arrayGroesse];
            int[] durch10TeilbareZahlen = new int[arrayGroesse];
            int[] groessereZahlen = new int[arrayGroesse];

            // Befüllen des Arrays mit Zufallszahlen
            for (int i = 0; i < arrayGroesse; i++)
            {
                array[i] = new Random().Next(100);
            }

            // Ausgabe des unsortierten Arrays
            Console.WriteLine("Unsortiertes Array:");
            for (int i = 0; i < arrayGroesse; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Geben Sie eine Zahl ein: ");
                int zahl = Convert.ToInt32(Console.ReadLine());
            // Zuordnung der Zahlen zu den einzelnen Arrays
            for (int i = 0; i < arrayGroesse; i++)
            {
                // gerade oder ungerade
                if (array[i] % 2 == 0)
                {
                    geradeZahlen[i] = array[i];
                }

                // durch 10 teilbar
                if (array[i] % 10 == 0)
                {
                    durch10TeilbareZahlen[i] = array[i];
                }

                // größer als eine vom User eingegebene Zahl
               
                if (array[i] > zahl)
                {
                    groessereZahlen[i] = array[i];
                }
            }

            // Ausgabe der sortierten Arrays
            Console.WriteLine("Gerade Zahlen:");
            for (int i = 0; i < geradeZahlen.Length; i++)
            {
                if (geradeZahlen[i] != 0)
                {
                    Console.WriteLine(geradeZahlen[i]);
                }
            }
            Console.WriteLine("Durch 10 teilbare Zahlen:");
            for (int i = 0; i < durch10TeilbareZahlen.Length; i++)
            {
                if (durch10TeilbareZahlen[i] != 0)
                {
                    Console.WriteLine(durch10TeilbareZahlen[i]);
                }
            }
            Console.WriteLine("Größere Zahlen:");
            for (int i = 0; i < groessereZahlen.Length; i++)
            {
                if (groessereZahlen[i] != 0)
                {
                    Console.WriteLine(groessereZahlen[i]);
                }
            }
        }
    }



