using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class hash
    {
        public static void Start()
        {
            int i = 0;
            int[] j = new int[1001];
            while (i < 1001)
            {

                j[i] = 19 - ((i * 97) % 19);
                i++;
                Array.Sort(j);



            }
            int z = 0;
            while (z < 1000)
            {
                int eins = 0, zwei = 0, drei = 0, vier = 0, fünf = 0, sechs = 0, sieben = 0, acht = 0, neun = 0, zehn = 0, elf = 0, zwölf = 0, dreizehn = 0, vierzehn = 0, fünfzehn = 0, sechszehn = 0, siebzehn = 0, achzehn = 0, neunzehn = 0;

                if (j[z] == 1)
                {
                    eins ++;
                }
                if (j[z] == 2)
                {
                    zwei ++;
                }
                if (j[z] == 3)
                {
                    drei ++;
                }
                if (j[z] == 4)
                { 
                    vier ++;
                }
                if (j[z] == 5)
                { fünf ++;}
                if (j[z] == 6)
                { sechs ++;}
                if (j[z] == 7)
                { sieben ++;}
                if (j[z] == 8)
                { acht ++;}
                if (j[z] == 9)
                { neun ++;}
                if (j[z] == 10)
                { zehn ++;}
                if (j[z] == 11)
                { elf ++;}
                if (j[z] == 12)
                { zwölf ++;}
                if (j[z] == 13)
                { dreizehn ++;}
                if (j[z] == 14)
                { vierzehn ++;}
                if (j[z] == 15)
                { fünfzehn ++;}
                if (j[z] == 16)
                { sechszehn ++;}
                if ((j[z] == 17))
                {
                    siebzehn++;
                }

            
            if (j[z] == 18)
            {
                achzehn++;
            }
            if (j[z] == 19)
            {
                neunzehn++;
            }
                Console.WriteLine("Die 1 kommt {0} mal vor.",eins);
                Console.WriteLine("Die 2 kommt {0} mal vor.",zwei);
                Console.WriteLine("Die 3 kommt {0} mal vor.",drei);
                Console.WriteLine("Die 4 kommt {0} mal vor.",vier);
                Console.WriteLine("Die 5 kommt {0} mal vor.",fünf);
                Console.WriteLine("Die 6 kommt {0} mal vor.",sechs);
                Console.WriteLine("Die 7 kommt {0} mal vor.",sieben);
                Console.WriteLine("Die 8 kommt {0} mal vor.",acht);
                Console.WriteLine("Die 9 kommt {0} mal vor.",neun);
                Console.WriteLine("Die 10 kommt {} mal vor.",zehn);
                Console.WriteLine("Die 11 kommt {} mal vor.",elf);
                Console.WriteLine("Die 12 kommt {} mal vor.",zwölf);
                Console.WriteLine("Die 13 kommt {} mal vor.",dreizehn);
                Console.WriteLine("Die 14 kommt {} mal vor.",vierzehn);
                Console.WriteLine("Die 15 kommt {} mal vor.",fünfzehn);
                Console.WriteLine("Die 16 kommt {} mal vor.",sechszehn);
                Console.WriteLine("Die 17 kommt {} mal vor.",siebzehn);
                Console.WriteLine("Die 18 kommt {} mal vor.",achzehn);
                Console.WriteLine("Die 19 kommt {} mal vor.",neunzehn);
                                                            
            }
        }
        
    }
}
