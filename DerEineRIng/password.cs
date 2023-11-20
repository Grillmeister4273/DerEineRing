using System;

class password
{
    public static void Start()
    {
        {
            Console.WriteLine("Willkommen zum Benutzerverwaltungs-Interface");
            Dictionary<string, string> userPasswords = new Dictionary<string, string>();

            while (true)
            {
                Console.Write("Geben Sie den Benutzernamen ein (oder 'exit' zum Beenden): ");
                string username = Console.ReadLine();

                if (username.ToLower() == "exit")
                    break;

                Console.Write("Geben Sie das Passwort für " + username + " ein: ");
                string password = GetPassword();

                userPasswords[username] = password;
            }

            Console.WriteLine("Benutzer und Passwörter:");
            foreach (var kvp in userPasswords)
            {
                Console.WriteLine("Benutzer: " + kvp.Key + ", Passwort: " + kvp.Value);
            }
        }

        static string GetPassword()
        {
            // Verwenden Sie ReadKey(), um das Passwort zu maskieren
            string password = "";
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);


                if (key.Key == ConsoleKey.Enter)
                    break;

                password += key.KeyChar;
                Console.Write("*");
            } while (true);

            Console.WriteLine(); // Um einen Zeilenumbruch nach dem Passwort zu erzeugen

            return password;
        }
    }
}



