using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class name
    {

        public static void Start()
        {

            //  using System;
            //  using System.Text;
            //class a
            {  // was macht new StringBuilder??
                Console.WriteLine("Input a password: ");
                StringBuilder sb = new StringBuilder();
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine();
                        break;
                    }
                    //  30-35 ermöglicht anscheinend das Löschen bei falscher Eingabe
                    if (cki.Key == ConsoleKey.Backspace)
                    {
                        if (sb.Length > 0)
                        {
                            Console.Write("\b\0\b");  //??
                            sb.Length--;
                        }

                        //continue; 
                    }

                    Console.Write('*');
                    sb.Append(cki.KeyChar);
                }
                Console.WriteLine($"Your password is: {sb.ToString()}");
            }
















            /*Console.WriteLine("Bitte geben Sie Ihr Passwort ein");
            string passwort = Console.ReadLine(), länge = "Länge: ", letzter ="Letzter Buchstabe: ";
            int zahl = passwort.Length;
            Console.WriteLine(länge + zahl);
            
            Console.WriteLine("Erster Buchstabe: " + passwort[0]);
            Console.WriteLine(letzter + passwort[zahl-1]);


            

            */


        }
    }
}

/*
 * StringBuilder -> Klasse kann nicht vererbt werden -> der Wert kann nicht weiter gegeben werden
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */
















