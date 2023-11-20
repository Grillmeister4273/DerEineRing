using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class zahlennn
    {
        public static void Start()
        {
            int[] Array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bitte geben sie die " + i + ". Zahl ein: ");
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out int number);
                if (success) { Array[i] = number; } else { Console.WriteLine("Die Eingabe ist keine Zahl."); i--; }
            }
            Console.WriteLine("Die Summe = " + Array.Sum()); bool b1 = Array.Last() == 5;
            if (b1) { Console.WriteLine("Die größte Zahl ist " + Array.Max()); }
            double k = Array.Average(); int M = Convert.ToInt32(k);
            Console.WriteLine("Der Mittelwert = " + M); Console.WriteLine("Die kleinste Zahl ist " + Array.Min()); Console.WriteLine("Die größte Zahl ist " + Array.Max());
        }
    }
}