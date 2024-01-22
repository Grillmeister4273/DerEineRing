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

        public static void Start()
        {
            
            Console.WriteLine("Which area would you like to calculate?");
            Console.WriteLine("Enter 1 for a rectangle, 2 for a triangle, and 3 for a circle.");
            if (!int.TryParse(Console.ReadLine(), out int selection))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                return;
            }

            switch (selection)
            {
                case 1:
                    CalculateRectangleArea();
                    break;
                case 2:
                    CalculateTriangleArea();
                    break;
                case 3:
                    CalculateCircleArea();
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
                    break;
            }
        }

        private static void CalculateRectangleArea()
        {
            Console.Write("What is the length (a)? ");
            double a = GetUserInput();
            Console.Write("What is the width (b)? ");
            double b = GetUserInput();
            double rectangleArea = a * b;
            Console.WriteLine($"The area of the rectangle is: {rectangleArea}");
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
