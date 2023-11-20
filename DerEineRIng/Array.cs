using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Bert
    {

        public static void Start()
        {
            /*     int[] arr0 = new int[4] {70, 30, 89, 13};
                 float fl1 = arr0[2];

                arr0[3]=arr0[3] + 17;

                 arr0 = new int[6] { 70, 30, 89, 30, 200, 500 };
                 arr0[0] = arr0[0] / 5;
                 arr0[1] = arr0[1] / 5;
                 arr0[2] = arr0[2] / 5;
                 arr0[3] = arr0[3] / 5;


                arr0[0] = arr0[0] *2;
                arr0[1] = arr0[1] *2;
                arr0[2] = arr0[2] *2;
                arr0[3] = arr0[3] *2;
                arr0[4] = arr0[4] *2;
                arr0[5] = arr0[5] *2;



                 Console.WriteLine("Erstes Element: " + arr0[0]);         
                 Console.WriteLine("Zweites Element: " + arr0[1]);        
                 Console.WriteLine("Drittes Element: " + arr0[2]);                                   
                 Console.WriteLine("Viertes Element: " + arr0[3]);                                   
                 Console.WriteLine("Fünftes Element: " + arr0[4]);                                   
                 Console.WriteLine("Sechstes Element: " +arr0[5]);
     */

            float fl1 = 110;
            int[] arr0 = new int[4] { 70, 30, 89, 13 };
            fl1 = arr0[2];

            arr0[3] = arr0[3] + 17;

            arr0 = new int[6] { 70, 30, 89, 30, 200, 500 };
            arr0[0] /= 5;
            arr0[1] /= 5;
            arr0[2] /= 5;
            arr0[3] /= 5;


            arr0[0] *= 2;
            arr0[1] *= 2;
            arr0[2] *= 2;
            arr0[3] *= 2;
            arr0[4] *= 2;
            arr0[5] *= 2;



            Console.WriteLine("Erstes Element: " + arr0[0]);
            Console.WriteLine("Zweites Element: " + arr0[1]);
            Console.WriteLine("Drittes Element: " + arr0[2]);
            Console.WriteLine("Viertes Element: " + arr0[3]);
            Console.WriteLine("Fünftes Element: " + arr0[4]);
            Console.WriteLine("Sechstes Element: " + arr0[5]);







        }
    }
}
