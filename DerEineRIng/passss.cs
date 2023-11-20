using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class passss
    {
        public static void Start()
        {
            Console.WriteLine("Willkommen zum Passworteingabe-Interface");

            // Rufen Sie die Methode zur Passworteingabe auf
            string password = GetPassword();

            // Überprüfen, ob das eingegebene Passwort korrekt ist
            if (IsCorrectPassword(password))
            {
                Console.WriteLine("Zugriff gewährt! Das Passwort ist korrekt.");
            }
            else
            {
                Console.WriteLine("Falsches Passwort. Zugriff verweigert.");
            }
        }

        static string GetPassword()
        {
            Console.Write("Bitte geben Sie das Passwort ein: ");

            // Verwenden Sie ReadKey(), um das Passwort zu maskieren
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);

                // Wenn die Eingabetaste gedrückt wird, brechen Sie die Schleife ab
                if (key.Key == ConsoleKey.Enter)
                    break;

                // Fügen Sie das Zeichen dem Passwort hinzu und ersetzen Sie es auf dem Bildschirm durch '*'
                password += key.KeyChar;
                Console.Write("*");
            } while (true);

            Console.WriteLine(); // Um einen Zeilenumbruch nach dem Passwort zu erzeugen

            return password;
        }

        static bool IsCorrectPassword(string password)
        {
            // Hier können Sie Ihre Logik zur Überprüfung des Passworts implementieren
            // In diesem Beispiel ist das richtige Passwort "geheim"
            return password == "Gertrude";

        }
    }
}

