using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Meth
    {

        public static int Addition(int a, int b)
        {
            return a + b;
        }   //gibt Summe zurück


        public static int Bigger(int a, int b)
        {
            if (a < b)
            { return a; }
            else
            { return b; }
        }   //gibt größere Zahl zurück

        public static string Umkehr(string a)
        {
                char[] reversed = new char[a.Length];
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    reversed[a.Length - i - 1] = a[i];
                }
                return new string(reversed);
        }   //gibt den String umgekehrt zurück

        public static int Durchschnitt ()






























    }
}
