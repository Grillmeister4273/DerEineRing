using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerEineRing
{
    internal class Flächenberechnung
    {
        private static double input;
        private static ShapeType selection;

        public enum ShapeType
        {
            Rectangle=1,
            Triangle=2,
            Circle=3,
            Brake=4
        }

        public static void Start()
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Which area would you like to calculate?");
                Console.WriteLine("Enter 1 for a rectangle, 2 for a triangle, 3 for a circle, or 4 to exit.");
                if (!int.TryParse(Console.ReadLine(), out int selection))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (selection)
            {
                case (int)ShapeType.Rectangle:
                    CalculateRectangleArea();
                    break;
                case (int)ShapeType.Triangle:
                    CalculateTriangleArea();
                    break;
                case (int)ShapeType.Circle:
                    CalculateCircleArea();
                    break;
                case (int)ShapeType.Brake:
                     continueCalculating = false;
                       break;
                default:
                    Console.WriteLine("Invalid selection. Please enter 1, 2, 3 or 4.");
                    break;
            }

                
                   
                   
                
            }


            

        }

        private static void CalculateRectangleArea()
        {
            Console.Write("What is the length (a)? ");
            double a = GetUserInput();
            Console.Write("What is the width (b)? ");
            double b = GetUserInput();
            double c = a * b;
            Console.WriteLine("The area of the rectangle is: "+c);
        }

        private static void CalculateTriangleArea()
        {
            Console.Write("What is the base (g)? ");
            double g = GetUserInput();
            Console.Write("What is the height (h)? ");
            double h = GetUserInput();
            double triangleArea = 0.5 * g * h;
            Console.WriteLine($"The area of the triangle is: {triangleArea}");
        }

        private static void CalculateCircleArea()
        {
            Console.Write("What is the radius (r)? ");
            double r = GetUserInput();
            double circleArea = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"The area of the circle is: {circleArea}");
        }

        private static double GetUserInput()
        {
            while (!double.TryParse(Console.ReadLine(), out double input))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
            return input;
        }
    }

}
