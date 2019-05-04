using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListReview
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Circle> circles = new List<Circle>();
            Console.WriteLine("Welcome to the Circle Tester");

            do
            {
                Console.Write("Enter radius: ");

                try
                {
                    circles.Add(new Circle(double.Parse(Console.ReadLine())));
                    Console.WriteLine($"Circumference: {circles.Last().CalcualteFormattedCircumference()}" +
                        $"\nArea: {circles.Last().CalcualteFormattedArea()}");
                }

                catch (Exception)
                {
                    Console.WriteLine("Invalid radius! Be sure to enter a valid number.");
                }

                Console.WriteLine("Would you like to enter another circle?(y/n)");
            } while (Console.ReadLine().ToLower() == "y");

            Console.WriteLine($"Goodbye. You created {circles.Count} circle(s).");
        }
    }
}
