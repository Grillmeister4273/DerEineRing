using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Aufgabe7
    {
        public static void Start()
        {
            string str1 = "wie ";
            string str2 = "dir?";
            string str3 = "es ";
            string str4 = "Danke, ";
            string str5 = "Hallo, ";
            string str6 = "geht ";
            string str7 = "gut!";
            string str8 = "mir ";

            string frage = string.Format("{0} {1} {2} {3} {4}", str5, str1, str6, str3, str2);
            string antwort = string.Format("{0} {1} {2} {3} {4}", str4, str8, str6, str3, str7);

            Console.WriteLine(frage + antwort);
        }
    }
}
