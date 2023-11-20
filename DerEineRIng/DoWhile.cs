using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class DoWhile
    {
        public static void Start()
        {
            /*bool dowhilebool = false;
            if (!int.TryParse(Console.ReadLine(), out int idowhile))
            {
                dowhilebool = true;
            }else { dowhilebool= false; }
            

            bool b1 = false;
            
            Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
            if (!int.TryParse(Console.ReadLine(), out int i)) { b1 = true; }
*/
            
            int summe = 0;
            int anzahlEintraege = 0;
            int eingabe;
            Console.WriteLine("Bitte Geben Sie eine Zahl ein: ");
            do
            {
                // Eingabe abfragen
              int.TryParse(Console.ReadLine(), out eingabe);
                Console.Clear();
                Console.WriteLine("Bitte Geben Sie eine gültige Zahl ein: ");
                // Eingabe prüfen
                if (eingabe > 0)
                {

                    
                    // Summe und Anzahl der Eingaben erhöhen
                    summe += eingabe;
                    anzahlEintraege++;
                }
            } while (summe <= 100);

            Console.WriteLine($"Summe: {summe}");
            Random rnd = new Random();
            int z = rnd.Next(1,anzahlEintraege);
            Console.WriteLine($"Anzahl Eingaben: {anzahlEintraege}");
            Console.WriteLine("Anzahl der Fehlversuche: "+z);
        }
    }
}
