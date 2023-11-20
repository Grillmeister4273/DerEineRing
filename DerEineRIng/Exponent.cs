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
            Console.WriteLine("Basis eingeben:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Exponent eingeben:");
            int b = int.Parse(Console.ReadLine());

            double result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }


            Console.WriteLine("a^b = " + result);
        }
    }
}
