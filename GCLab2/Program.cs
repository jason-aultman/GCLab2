using System;

namespace GCLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = false;
            do
            {
                System.Console.Clear();  //Went outside scope of project for cleanliness
                Console.WriteLine("Welcome to Jason's Room Detail Generator");
                Console.WriteLine();
                Console.Write("Enter length: ");
                var lengthPassed= double.TryParse(Console.ReadLine(), out double lengthAsDouble);
                Console.Write("Enter width: ");
                var widthPassed = double.TryParse(Console.ReadLine(), out double widthAsDouble);
                Console.WriteLine();
                if (!lengthPassed || !widthPassed) //input validation to prevent program crash on bad input --TODO add another loop within system to reenter input.
                {
                    Console.WriteLine("There was a problem with the input. Please try again.  Exiting...");
                    return;
                }
                Console.WriteLine("Area: " + (lengthAsDouble*widthAsDouble));
                Console.WriteLine("Perimeter: " + ((2 * lengthAsDouble) + (2 * widthAsDouble)));
                Console.WriteLine();
                Console.Write("Continue? (y/n) ");
                var doMore = Console.ReadLine();
                if (doMore == "y" || doMore == "Y")
                {
                    again = true;
                }
                else again = false;
            } while (again);
        }
    }
}
