using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Exponent
    {
        public static void Start()
        {
            bool lol = false;
            Console.WriteLine("Basis eingeben:");
            double a = 0;
                lol = double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Exponent eingeben:");
            int b = 0;
               lol = int.TryParse(Console.ReadLine(), out b);

            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            } 


            Console.WriteLine("a^b = " + result);
        }
    }
}
