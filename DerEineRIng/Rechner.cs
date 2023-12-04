using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Rechner
        
    {
        public static void Start()
        {
            Console.WriteLine("gib zwei Zahlen und das Rechenzeichen ein");
            Console.Write("erste Zahl: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("zweite Zahl: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Rechenzeichen (+,-,*,%): ");
            string rechenzeichen = Console.ReadLine();

            double ergebnis = 0;
            switch (rechenzeichen)
            {
                    case "+":
                    {
                        ergebnis = x + y; break;
                    }
                    case "-":
                    {
                        ergebnis = x - y; break;
                    }
                    case "*":
                    {
                        ergebnis = x * y; break;
                    }
                    case "/":
                    {
                        ergebnis = x / y; break;
                    }
                    case "%":
                    {
                        ergebnis = x % y; break;
                    }
            }
                
            

        
            Console.Clear();
            Console.WriteLine(x + rechenzeichen + y +" ist " + ergebnis);
        }
    }
}
