using System;

class Aufgabe_23
{
    public static void Start()
    {
        Console.WriteLine("Eingabeaufforderung: \n Abbruch mit 'exit'"); string[] eingaben = new string[10000] ;
        int index = 0;
        while (true)
        {
            string eingabe = Console.ReadLine();
            if (eingabe == "exit")
            {
                break;
            }
            string verarbeiteteEingabe = VerarbeiteEingabe(eingabe);
            eingaben[index] = verarbeiteteEingabe;
            index++;
        }
            string output = "";
        string[] gertrude = new string[50] ;
        Array.Copy(eingaben, gertrude, eingaben.Length);
        foreach (string value in eingaben)
            {
                output += value + " und ";
            }
           int  z = output.Length;
            z -= 4;
            output =output.Substring (0,z);
            Console.WriteLine (output);
        
    }
    public static string VerarbeiteEingabe(string eingabe)
    {
        eingabe = eingabe.Replace("a", "");
        eingabe = eingabe.Replace("e", "");
        eingabe = eingabe.Replace("i", "");
        eingabe = eingabe.Replace("o", "");
        eingabe = eingabe.Replace("u", "");
        if (eingabe.Length > 5)
        {
            eingabe = eingabe.Replace("s", "");
            eingabe = eingabe.Replace("t", "");
            eingabe = eingabe.Replace("d", "");
        }

        return eingabe;
    }
}