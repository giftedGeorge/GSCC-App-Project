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
            string menuChoice1 = Console.ReadLine();
            string menuChoice2 = "";
            string menuChoice3 = "";

            //Implementing the exponent feature
            string userChoice = "1";

            if (menuChoice1 == "1")
            {
                Console.WriteLine("**You have selected Exponent**\n");

                do
                {
                    Console.Write("Enter base value: ");
                    double baseVal = GeneralMethods.collectDoubleInput();
                    Console.Write("Enter Power value: ");
                    double powerVal = GeneralMethods.collectDoubleInput();
                    double result = Math.Pow(Math.Abs(baseVal), powerVal);
                    if (((powerVal % 2) != 0) && baseVal < 0)
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

                    while (userChoice != "1" && userChoice != "2")
                    {
                        Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                        userChoice = Console.ReadLine();
                    }

                }
                while (userChoice == "1");
            }

            //Implementing the Trigonometry feature
            else if (menuChoice1 == "2")
            {
                Console.WriteLine("**You have selected Trigonometry**\n\nWhat do you want to do?\n 1. Sine\n 2. Cosine\n 3. Tangent\n");
                Console.Write("Enter an option to continue: ");
                menuChoice2 = Console.ReadLine();

                if (menuChoice2 == "1")
                {
                    Console.WriteLine("**You have selected Sine**\n\nWhat do you want to do?\n 1. Sine of a known angle\n 2. Sine of an unknown angle\n 3. Sine inverse of a value\n");
                    Console.Write("Enter an option to continue: ");
                    menuChoice3 = Console.ReadLine();

                    if (menuChoice3 == "1")
                    {
                        Console.WriteLine("**You have selected Sine of a known angle**\n");

                        do
                        {
                            Console.Write("Enter the value of the angle in degrees: ");
                            double angleValue = GeneralMethods.collectDoubleInput();
                            double result = Math.Sin(GeneralMethods.DegreesToRadians(angleValue));
                            Console.WriteLine($"Sin{angleValue} Degrees = {result}\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else if (menuChoice3 == "2")
                    {
                        Console.WriteLine("**You have selected Sine of an unknown angle**\n");

                        do
                        {
                            Console.Write("Enter the value of the Opposite side: ");
                            double oppValue = GeneralMethods.collectDoubleInput();
                            Console.Write("Enter the value of the Hypotenuse side: ");
                            double hypValue = GeneralMethods.collectDoubleInput();
                            double result = GeneralMethods.RadiansToDegrees(Math.Asin(oppValue / hypValue));
                            Console.WriteLine($"The unknown angle is {result} Degrees\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else if (menuChoice3 == "3")
                    {
                        Console.WriteLine("**You have selected Sine inverse of a value**\n");

                        do
                        {
                            Console.Write("Enter the number value: ");
                            double numValue = GeneralMethods.collectDoubleInput();
                            double result = GeneralMethods.RadiansToDegrees(Math.Asin(numValue));
                            Console.WriteLine($"Sin-1 {numValue} = {result} Degrees\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else
                    {
                        Console.WriteLine("Error! Please enter the numeric value of an option in the menu.");
                    }

                }

                else if (menuChoice2 == "2")
                {
                    Console.WriteLine("**You have selected Cosine**\n\nWhat do you want to do?\n 1. Cosine of a known angle\n 2. Cosine of an unknown angle\n 3. Cosine inverse of a value\n");
                    Console.Write("Enter an option to continue: ");
                    menuChoice3 = Console.ReadLine();

                    if (menuChoice3 == "1")
                    {
                        Console.WriteLine("**You have selected Cosine of a known angle**\n");

                        do
                        {
                            Console.Write("Enter the value of the angle in degrees: ");
                            double angleValue = GeneralMethods.collectDoubleInput();
                            double result = Math.Cos(GeneralMethods.DegreesToRadians(angleValue));
                            Console.WriteLine($"Cos{angleValue} Degrees = {result}\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else if (menuChoice3 == "2")
                    {
                        Console.WriteLine("**You have selected Cosine of an unknown angle**\n");

                        do
                        {
                            Console.Write("Enter the value of the Adjacent side: ");
                            double adjValue = GeneralMethods.collectDoubleInput();
                            Console.Write("Enter the value of the Hypotenuse side: ");
                            double hypValue = GeneralMethods.collectDoubleInput();
                            double result = GeneralMethods.RadiansToDegrees(Math.Acos(adjValue / hypValue));
                            Console.WriteLine($"The unknown angle is {result} Degrees\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else if (menuChoice3 == "3")
                    {
                        Console.WriteLine("**You have selected Cosine inverse of a value**\n");

                        do
                        {
                            Console.Write("Enter the number value: ");
                            double numValue = GeneralMethods.collectDoubleInput();
                            double result = GeneralMethods.RadiansToDegrees(Math.Acos(numValue));
                            Console.WriteLine($"Cos-1 {numValue} = {result} Degrees\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else
                    {
                        Console.WriteLine("Error! Please enter the numeric value of an option in the menu.");
                    }

                }

                else if (menuChoice2 == "3")
                {
                    Console.WriteLine("**You have selected Tangent**\n\nWhat do you want to do?\n 1. Tangent of a known angle\n 2. Tangent of an unknown angle\n 3. Tangent inverse of a value\n");
                    Console.Write("Enter an option to continue: ");
                    menuChoice3 = Console.ReadLine();

                    if (menuChoice3 == "1")
                    {
                        Console.WriteLine("**You have selected Tangent of a known angle**\n");

                        do
                        {
                            Console.Write("Enter the value of the angle in degrees: ");
                            double angleValue = GeneralMethods.collectDoubleInput();
                            double result = Math.Tan(GeneralMethods.DegreesToRadians(angleValue));
                            Console.WriteLine($"Tan{angleValue} Degrees = {result}\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else if (menuChoice3 == "2")
                    {
                        Console.WriteLine("**You have selected Tangent of an unknown angle**\n");

                        do
                        {
                            Console.Write("Enter the value of the Opposite side: ");
                            double oppValue = GeneralMethods.collectDoubleInput();
                            Console.Write("Enter the value of the Adjacent side: ");
                            double adjValue = GeneralMethods.collectDoubleInput();
                            double result = GeneralMethods.RadiansToDegrees(Math.Atan((oppValue / adjValue)));
                            Console.WriteLine($"The unknown angle is {result} Degrees\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else if (menuChoice3 == "3")
                    {
                        Console.WriteLine("**You have selected Tangent inverse of a value**\n");

                        do
                        {
                            Console.Write("Enter the number value: ");
                            double numValue = GeneralMethods.collectDoubleInput();
                            double result = GeneralMethods.RadiansToDegrees(Math.Atan(numValue));
                            Console.WriteLine($"Tan-1 {numValue} = {result} Degrees\n\nDo another ?\n 1.Yes\n 2.No\n");
                            Console.Write("Enter 1 to continue, or 2 to exit: ");
                            userChoice = Console.ReadLine();

                            while (userChoice != "1" && userChoice != "2")
                            {
                                Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                                userChoice = Console.ReadLine();
                            }
                        }
                        while (userChoice == "1");
                    }

                    else
                    {
                        Console.WriteLine("Error! Please enter the numeric value of an option in the menu.");
                    }
                }
            }

            //Implementing the Permutation feature
            else if (menuChoice1 == "3")
            {
                Console.WriteLine("**You have selected Permutation**\n");

                do
                {
                    Console.Write("Enter the value of n: ");
                    int nValue = GeneralMethods.collectIntegerInput();
                    Console.Write("Enter the value of r: ");
                    int rValue = GeneralMethods.collectIntegerInput();
                    var result = PermutationAndCombination.NPr(nValue, rValue);
                    Console.WriteLine($"{nValue}P{rValue} = {result}\n\nDo another?\n 1. Yes\n 2. No\n");
                    Console.Write("Enter 1 to continue, or 2 to exit: ");
                    userChoice = Console.ReadLine();

                    while (userChoice != "1" && userChoice != "2")
                    {
                        Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                        userChoice = Console.ReadLine();
                    }

                }
                while (userChoice == "1");
            }

            //Implementing the Combination feature
            else if (menuChoice1 == "4")
            {
                Console.WriteLine("**You have selected Combination**\n");

                do
                {
                    Console.Write("Enter the value of n: ");
                    int nValue = GeneralMethods.collectIntegerInput();
                    Console.Write("Enter the value of r: ");
                    int rValue = GeneralMethods.collectIntegerInput();
                    var result = PermutationAndCombination.NCr(nValue, rValue);
                    Console.WriteLine($"{nValue}C{rValue} = {result}\n\nDo another?\n 1. Yes\n 2. No\n");
                    Console.Write("Enter 1 to continue, or 2 to exit: ");
                    userChoice = Console.ReadLine();

                    while (userChoice != "1" && userChoice != "2")
                    {
                        Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                        userChoice = Console.ReadLine();
                    }

                }
                while (userChoice == "1");
            }

            //Implementing the Logarithm feature
            else if (menuChoice1 == "5")
            {
                Console.WriteLine("**You have selected Logarithm**\n");

                do
                {
                    Console.Write("Enter value in base 10: ");
                    double numValue = GeneralMethods.collectDoubleInput();
                    var result = Math.Log(numValue, 10);
                    Console.WriteLine($"log {numValue} = {result}\n\nDo another ?\n 1.Yes\n 2.No\n");
                    Console.Write("Enter 1 to continue, or 2 to exit: ");
                    userChoice = Console.ReadLine();

                    while (userChoice != "1" && userChoice != "2")
                    {
                        Console.Write("Invalid entry! Please enter 1 to continue, or 2 to exit: ");
                        userChoice = Console.ReadLine();
                    }

                }
                while (userChoice == "1");
            }           

        }
    }
}
