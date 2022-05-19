using System;

namespace Scientific_Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementing initial Display Menu.
            Console.WriteLine("***Welcome to George's Scientific calculator***\n\n" +
                "What would you like to do?\n" +
                "Please enter the numeric value of an option below to proceed\n" +
                "1. Exponent\n" +
                "2. Trigonometry\n" +
                "3. Permutation\n" +
                "4. Combination\n" +
                "5. Logarithm\n" +
                "6. View History\n");

            Console.Write("Enter a numeric Value: ");
            string menuChoice = Console.ReadLine();

            //Implementing the exponent feature
            if (menuChoice == "1")
            {
                Console.WriteLine("**You have selected Exponent**\n");
                string userChoice = "1";

                do
                {
                    Console.Write("Enter base value: ");
                    double baseVal = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter Power value: ");
                    double powerVal = Convert.ToDouble(Console.ReadLine());
                    double result = Math.Pow(baseVal, powerVal);
                    Console.WriteLine($"{baseVal} to the power of {powerVal} = {result}\n\n" + "Do another?\n" + "1. Yes\n" + "2. No\n");
                    Console.Write("Enter 1 to continue, 2 to exit: ");
                    userChoice = Console.ReadLine();

                    while (userChoice != "1" && userChoice != "2")
                    {
                        Console.Write("Invalid entry! Please enter 1 to continue, 2 to exit: ");
                        userChoice = Console.ReadLine();
                    }
                }
                while (userChoice == "1");
            }
        }
    }
}
