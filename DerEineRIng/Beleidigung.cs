using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Beleidigung
    {
        
            public static void Start()
            {
                // Begrüßung des Benutzers
                Console.WriteLine("Hallo, was willst du von mir?");

                // Eingabe der Erwiderung des Benutzers
                string erwiderung = Console.ReadLine();

                // Generierung einer zufälligen Beleidigung
                int index = new Random().Next(29);
                string beleidigung = "";
                switch (index)
                {
                    case 0:
                        beleidigung = "Du bist ein kliener Giftzwerg"; break;
                    case 1:
                        beleidigung = "Deine Mutter arbeitet bei Kik unter der Kasse als Piepston."; break;
                    case 2:
                        beleidigung = "Du stinkend so dermaßen,du könntest eine Müllhalde übertreffen."; break;
                    case 3:
                        beleidigung = "Du bist so dumm."; break;
                    case 4:
                        beleidigung = "Du bist so hässlich."; break;
                    case 5:
                        beleidigung = "Du kleine Abtreibung"; break;
                    case 6:
                        beleidigung ="Du Vollidiot!";break;  
                    case 7:
                        beleidigung ="Du hässlicher Mongo";break;  
                    case 8:
                        beleidigung ="MONGO!";break;
                    case 9:
                        beleidigung ="Du puscht doch bestimmt Mongo?!";break;
                    case 10:
                        beleidigung ="Du fährst doch bestimmt Goofy?!";break;
                    case 11:
                        beleidigung ="Arschloch";break;
                    case 12:
                        beleidigung ="Haha, du bist hässlich!!";break;
                    case 13:
                        beleidigung =" ";break;
                    case 14:
                        beleidigung =" ";break;
                    case 15:
                        beleidigung =" ";break;
                    case 16:
                        beleidigung =" ";break;
                    case 17:
                        beleidigung =" "; break;
                    case 18:
                        beleidigung =" "; break;
                    case 19:
                        beleidigung =" "; break;
                    case 20:
                        beleidigung =" "; break;
                    case 21:
                        beleidigung =" "; break;
                    case 22:
                        beleidigung =" "; break;
                    case 23:
                        beleidigung =" "; break;
                    case 24:
                        beleidigung =" "; break;
                    case 25:
                        beleidigung =" "; break;
                    case 26:
                        beleidigung =" "; break;
                    case 27:
                        beleidigung =" "; break;
                    case 28:
                        beleidigung = " "; break;
                    default:
                        beleidigung = "Du bist ein Arschloch.";
                        break;
                }

                // Ausgabe der Beleidigung
                Console.WriteLine(beleidigung);
            }
        }
    }

