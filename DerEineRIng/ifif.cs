using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class ifif
    {
        public static void Start()
        {

            Console.WriteLine("Bitte machen Sie eine Eingaben: ");
            string inputString = Console.ReadLine();
            Console.Clear();
            bool boool1 = int.TryParse(inputString, out int zahl);
            if (boool1 == false)
            {
                int length = inputString.Length;
                int middle = length / 2;

                string firstHalf;
                string middleCharacter;
                string secondHalf;

                if (length % 2 == 0)
                {
                    // Wenn die Länge gerade ist
                    firstHalf = inputString.Substring(0, middle);
                    middleCharacter = inputString.Substring(middle, 1);
                    secondHalf = inputString.Substring(middle + 1);
                }
                else
                {
                    // Wenn die Länge ungerade ist
                    firstHalf = inputString.Substring(0, middle);
                    middleCharacter = inputString.Substring(middle, 1);
                    secondHalf = inputString.Substring(middle + 1);
                }

                Console.WriteLine("Erste Hälfte: " + firstHalf);
                Console.WriteLine("Mittlerer Buchstabe: " + middleCharacter);
                Console.WriteLine("Zweite Hälfte: " + secondHalf);
            }
            if (boool1 == true)
            {
                int half = zahl / 2;
                int remainder = zahl % 2;

                if (remainder == 0)
                {
                    Console.WriteLine("Die Hälfte der eingegebene Zahl ist " + half);
                }
                else
                {
                    Console.WriteLine("Hälfte: " + half);
                    Console.WriteLine("Rest: " + remainder);
                }
            }



        }
        /*Console.WriteLine("Bitte geben Sie einen Wert ein: ");
          string wert = Console.ReadLine();
          Console.Clear();
          int werT = 0;
          if (int.TryParse(wert, out werT))

          {
              var werthalb = wert[..(wert.Length / 2)];
              string wertrest = wert;
              if (werT <= 0)
              {
                  Console.Write($"Der eingegebene Wert " + wert + "ist ein String und die Hälfte ist " + werthalb);
                 if (wertrest < wert.Length)
                 { Console.Write($"mit dem mittleren Buchstabe ist " + wertrest); }

                 */






    }




}




