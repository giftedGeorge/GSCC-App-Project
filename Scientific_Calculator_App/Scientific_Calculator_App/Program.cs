using System;
using System.Numerics;

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
            string userChoice = "1";
            while (userChoice != "1" && userChoice != "2")
            {
                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                userChoice = Console.ReadLine();
            }

            if (menuChoice == "1")
            {
                Console.WriteLine("**You have selected Exponent**\n");                

                do
                {
                    try
                    {
                        Console.Write("Enter base value: ");
                        double baseVal = GeneralMethods.collectDoubleInput();
                        Console.Write("Enter Power value: ");
                        double powerVal = GeneralMethods.collectDoubleInput();
                        double result = Math.Pow(Math.Abs(baseVal), powerVal);
                        if ((powerVal % 2) != 0)
                        {
                            result = -result;
                            Console.WriteLine($"{baseVal} to the power of {powerVal} = {result}\n\nDo another?\n 1. Yes\n 2. No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"{baseVal} to the power of {powerVal} = {result}\n\nDo another?\n 1. Yes\n 2. No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error! Please enter a valid number value\n");
                    }
                }                
                while (userChoice == "1");
            }

            //Implementing the Permutation feature
            else if (menuChoice == "3")
            {
                Console.WriteLine("**You have selected Permutation**\n");

                do
                {
                    try
                    {
                        Console.Write("Enter the value of n: ");
                        int nValue = GeneralMethods.collectIntegerInput();
                        Console.Write("Enter the value of r: ");
                        int rValue = GeneralMethods.collectIntegerInput();
                        var result = PermutationAndCombination.NPr(nValue, rValue);
                        Console.WriteLine($"{nValue}P{rValue} = {result}\n\nDo another?\n 1. Yes\n 2. No\n");
                        Console.Write("Enter 1 to continue, or 2 to exit: ");
                        userChoice = Console.ReadLine();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error! Please enter a valid integer value\n");
                    }
                }
                while (userChoice == "1");
            }                                                  
        }
    }
}
