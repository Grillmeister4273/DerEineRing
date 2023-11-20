using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Polizei
    {
        public static void Start()
        {
            string inputString = " werPolizeidjsue ";
            inputString = inputString.Trim();
            Console.WriteLine(inputString);
            int i = inputString.Length;
            Console.WriteLine("Anzahl:" + i);
            inputString = inputString.Substring(3, 7);
            Console.WriteLine(inputString);
            inputString = inputString.ToUpper();
            Console.WriteLine(inputString);

        }
    }

}
