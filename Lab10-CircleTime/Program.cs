using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_CircleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Tester.");
            int loopCount = 0;

            bool runAgain = true;
            while (runAgain)
            {
                loopCount++;
                double radius = GetDecimal("What is the radius of the circle?");
                Console.WriteLine($"Radius: {radius}");
                Circle[] circles = new Circle[loopCount];
                for (int i = 0; i < loopCount; i++)
                {
                    circles[i] = new Circle();
                    circles[i].Radius = radius;

                    string circumference = circles[i].CalculateFormattedCircumference();
                    string area = circles[i].CalculateFormattedArea();
                    Console.WriteLine($"Circumference: {circumference}\nArea: {area}");
                }
                runAgain = Validator.RunAgain("Would you like to enter the radius of another circle?", loopCount);
            }
        }
        public static double GetDecimal(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                if (number > 0)
                {
                    return Math.Round(number, 2);
                }
                else
                {
                    Console.WriteLine("That isn't a valid radius.");
                    return GetDecimal(message);
                }
            }
            else
            {
                Console.WriteLine("That isn't a valid radius.");
                return GetDecimal(message);
            }
        }
    }
}                      
                        //Console.WriteLine($"Radius: {radius}");
                        //Circle circle1 = new Circle();
                        //circle1.Radius = radius;
                        ///alternate method for lines 22-30
