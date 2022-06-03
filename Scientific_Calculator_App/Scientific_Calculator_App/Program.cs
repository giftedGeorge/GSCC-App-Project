using System;
using System.Collections;
using System.Numerics;

namespace Scientific_Calculator_App
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            string menuChoice1; //for the main menu feature
            string menuChoice2; //for the trigonometry feature
            string menuChoice3; //for the trigonometry feature
            string userChoice = "1"; //will be used to take in the user input in the "Do another" menu which will pop up after every calculation.
            ArrayList userHistory = new(); //for the user history feature            

            do //do-while loop to restart the app while userChoice is 2 
            {
                //Implementing initial Display Menu.
                Console.Clear(); //Will clear the console on every loop
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
                menuChoice1 = Console.ReadLine();

                //Implementing the exponent feature
                if (menuChoice1 == "1") //Case for Main menu feature 1
                {
                    do //do-while loop to execute the Exponent feature while userChoice is 1
                    {
                        Console.Clear();
                        Console.WriteLine("**You have selected Exponent**\n");                        
                        Console.Write("Enter base value: ");
                        double baseVal = GeneralMethods.CollectDoubleInput();
                        Console.Write("Enter Power value: ");
                        double powerVal = GeneralMethods.CollectDoubleInput();
                        double result = Math.Pow(Math.Abs(baseVal), powerVal);
                        if (((powerVal % 2) != 0) && baseVal < 0)
                        {
                            result = -result;
                            userHistory.Add($"Exponent  |  {baseVal}^{powerVal} = {result}  |  {DateTime.Now}");
                            Console.WriteLine($"{baseVal} to the power of {powerVal} = {result}\n\n");
                            Console.Write("Enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                        else
                        {
                            userHistory.Add($"Exponent  |  {baseVal}^{powerVal} = {result}  |  {DateTime.Now}");
                            Console.WriteLine($"{baseVal} to the power of {powerVal} = {result}\n\n");
                            Console.Write("Enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                            userChoice = Console.ReadLine();
                        }

                        while (userChoice != "1" && userChoice != "2" && userChoice != "3") //userChoice validation
                        {
                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu or 3 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                    }
                    while (userChoice == "1");
                }

                //Implementing the Trigonometry feature
                else if (menuChoice1 == "2") //Case for Main menu option 2
                {
                    do //do-while loop to execute the trig feature while userChoice is 4.
                    {
                        Console.Clear();
                        Console.WriteLine("**You have selected Trigonometry**\n\nWhat do you want to do?\n 1. Sine\n 2. Cosine\n 3. Tangent\n");
                        Console.Write("Enter an option to continue: ");
                        menuChoice2 = Console.ReadLine();

                        if (menuChoice2 == "1") //Case for Trig menu option 1 (sine)
                        {
                            do //do-while loop to execute the sine sub-feature while userChoice is 3
                            {
                                Console.Clear();
                                Console.WriteLine("**You have selected Sine**\n\nWhat do you want to do?\n 1. Sine of a known angle\n 2. Sine of an unknown angle\n 3. Sine inverse of a value\n");
                                Console.Write("Enter an option to continue: ");
                                menuChoice3 = Console.ReadLine();
                            
                                if (menuChoice3 == "1") //Case for sine menu option 1
                                {
                                    do //do-while loop to execute Sine of a known angle sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Sine of a known angle**\n");
                                        Console.Write("Enter the value of the angle in degrees: ");
                                        double angleValue = GeneralMethods.CollectDoubleInput();
                                        double result = Math.Sin(GeneralMethods.DegreesToRadians(angleValue));
                                        userHistory.Add($"Trig (Sin of a known angle)  |  Sin{angleValue} = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"Sin{angleValue} Degrees = {result}\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to sine menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to sine menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else if (menuChoice3 == "2") //Case for sine menu option 2
                                {
                                    do //do-while loop to execute Sine of an unknown angle sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Sine of an unknown angle**\n");
                                        Console.Write("Enter the value of the Opposite side: ");
                                        double oppValue = GeneralMethods.CollectDoubleInput();
                                        Console.Write("Enter the value of the Hypotenuse side: ");
                                        double hypValue = GeneralMethods.CollectDoubleInput();
                                        double result = GeneralMethods.RadiansToDegrees(Math.Asin(oppValue / hypValue));
                                        userHistory.Add($"Trig (Sin of an unknown angle)  |  Sin-1({oppValue}/{hypValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"The unknown angle is {result} Degrees\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to sine menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to sine menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else if (menuChoice3 == "3") //Case for sine menu option 3
                                {
                                    do //do-while loop to execute Sine inverse of a value sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Sine inverse of a value**\n");                                    
                                        Console.Write("Enter the number value: ");
                                        double numValue = GeneralMethods.CollectDoubleInput();
                                        double result = GeneralMethods.RadiansToDegrees(Math.Asin(numValue));
                                        userHistory.Add($"Trig (Sin-1 of a value)  |  Sin-1({numValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"Sin-1({numValue}) = {result} Degrees\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to sine menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to sine menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else //Default case for Sine menu options
                                {
                                    while (menuChoice3 != "1" && menuChoice3 != "2" && menuChoice3 != "3") //menuChoice3 Validation
                                    {
                                        Console.WriteLine("Error! Please enter the numeric value of an option in the Sine menu.");
                                        Console.Write("Enter an option: ");
                                        menuChoice3 = Console.ReadLine();
                                    }
                                }
                            }
                            while (userChoice == "3");
                        }

                        else if (menuChoice2 == "2") //Case for Trig menu option 2 (Cosine)
                        {
                            do //do-while loop to execute the Cosine sub-feature while userChoice is 3
                            {
                                Console.Clear();
                                Console.WriteLine("**You have selected Cosine**\n\nWhat do you want to do?\n 1. Cosine of a known angle\n 2. Cosine of an unknown angle\n 3. Cosine inverse of a value\n");
                                Console.Write("Enter an option to continue: ");
                                menuChoice3 = Console.ReadLine();

                                if (menuChoice3 == "1") //Case for Cosine menu option 1
                                {
                                    
                                    do //do-while loop to execute the Cosine of a known angle sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Cosine of a known angle**\n");
                                        Console.Write("Enter the value of the angle in degrees: ");
                                        double angleValue = GeneralMethods.CollectDoubleInput();
                                        double result = Math.Cos(GeneralMethods.DegreesToRadians(angleValue));
                                        userHistory.Add($"Trig (Cos of a known angle)  |  Cos({angleValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"Cos({angleValue}) Degrees = {result}\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to Cosine menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to Cosine menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else if (menuChoice3 == "2") //Case for Cosine menu option 2 
                                {
                                    
                                    do //do-while loop to execute the Cosine of an unknown angle sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Cosine of an unknown angle**\n");
                                        Console.Write("Enter the value of the Adjacent side: ");
                                        double adjValue = GeneralMethods.CollectDoubleInput();
                                        Console.Write("Enter the value of the Hypotenuse side: ");
                                        double hypValue = GeneralMethods.CollectDoubleInput();
                                        double result = GeneralMethods.RadiansToDegrees(Math.Acos(adjValue / hypValue));
                                        userHistory.Add($"Trig (Cos of an unknown angle)  |  Cos-1({adjValue}/{hypValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"The unknown angle is {result} Degrees\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to Cosine menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to Cosine menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else if (menuChoice3 == "3") //Case for cosine menu option 3 
                                {
                                    
                                    do //do-while loop to execute the Cosine inverse of a value sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Cosine inverse of a value**\n");
                                        Console.Write("Enter the number value: ");
                                        double numValue = GeneralMethods.CollectDoubleInput();
                                        double result = GeneralMethods.RadiansToDegrees(Math.Acos(numValue));
                                        userHistory.Add($"Trig (Cos-1 of a value)  |  Cos-1({numValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"Cos-1({numValue}) = {result} Degrees\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to Cosine menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to Cosine menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else //Default case for Cosine menu options
                                {
                                    while(menuChoice3 != "1" && menuChoice3 != "2" && menuChoice3 != "3") //menuChoice3 Validation
                                    {
                                        Console.WriteLine("Error! Please enter the numeric value of an option in the Cosine menu.");
                                        Console.Write("Enter an option: ");
                                        menuChoice3 = Console.ReadLine();
                                    }                                    
                                }
                            }
                            while (userChoice == "3");
                                

                        }

                        else if (menuChoice2 == "3") //Case for Trig menu option 3 (Tangent)
                        {
                            do //do-while loop to execute the Tangent sub-feature while userChoice is 3
                            {
                                Console.Clear();
                                Console.WriteLine("**You have selected Tangent**\n\nWhat do you want to do?\n 1. Tangent of a known angle\n 2. Tangent of an unknown angle\n 3. Tangent inverse of a value\n");
                                Console.Write("Enter an option to continue: ");
                                menuChoice3 = Console.ReadLine();

                                if (menuChoice3 == "1") //Case for Tangent menu option 1
                                {                                    
                                    do //do-while loop to execute the Tangent of a known angle sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Tangent of a known angle**\n");
                                        Console.Write("Enter the value of the angle in degrees: ");
                                        double angleValue = GeneralMethods.CollectDoubleInput();
                                        double result = Math.Tan(GeneralMethods.DegreesToRadians(angleValue));
                                        userHistory.Add($"Trig (Tan of a known angle)  |  Tan({angleValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"Tan({angleValue}) Degrees = {result}\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to Tangent menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to Tangent menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else if (menuChoice3 == "2") //Case for Tangent menu option 2
                                {
                                    do //do-while loop to execute the Tangent of an unknown angle sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Tangent of an unknown angle**\n");
                                        Console.Write("Enter the value of the Opposite side: ");
                                        double oppValue = GeneralMethods.CollectDoubleInput();
                                        Console.Write("Enter the value of the Adjacent side: ");
                                        double adjValue = GeneralMethods.CollectDoubleInput();
                                        double result = GeneralMethods.RadiansToDegrees(Math.Atan((oppValue / adjValue)));
                                        userHistory.Add($"Trig (Tan of an unknown angle)  |  Tan-1({oppValue}/{adjValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"The unknown angle is {result} Degrees\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to Tangent menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to Tangent menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else if (menuChoice3 == "3") //Case for Tangent menu option 3
                                {
                                    do //do-while loop to execute the Tangent inverse of a value sub-feature while userChoice is 1
                                    {
                                        Console.Clear();
                                        Console.WriteLine("**You have selected Tangent inverse of a value**\n");
                                        Console.Write("Enter the number value: ");
                                        double numValue = GeneralMethods.CollectDoubleInput();
                                        double result = GeneralMethods.RadiansToDegrees(Math.Atan(numValue));
                                        userHistory.Add($"Trig (Tan-1 of a value)  |  Tan-1({numValue}) = {result}  |  {DateTime.Now}");
                                        Console.WriteLine($"Tan-1({numValue}) = {result} Degrees\n\n");
                                        Console.Write("Enter 1 to do another, 2 to return to main menu, 3 to return to Tangent menu, 4 to return to Trig menu, or 5 to exit: ");
                                        userChoice = Console.ReadLine();

                                        while (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4" && userChoice != "5") //userChoice validation
                                        {
                                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, 3 to return to Tangent menu, 4 to return to Trig menu, or 5 to exit: ");
                                            userChoice = Console.ReadLine();
                                        }
                                    }
                                    while (userChoice == "1");
                                }

                                else //Default case for Tangent menu options
                                {
                                    while(menuChoice3 != "1" && menuChoice3 != "2" && menuChoice3 != "3") //menuChoice3 Validation
                                    {
                                        Console.WriteLine("Error! Please enter the numeric value of an option in the Tangent menu.");
                                        Console.Write("Enter an option: ");
                                        menuChoice3 = Console.ReadLine();
                                    }                                    
                                }                                
                            }
                            while (userChoice == "3");
                        }

                        else //Default case for Trig menu options
                        {
                            while(menuChoice2 != "1" && menuChoice2 != "2" && menuChoice2 != "3") //menuChoice2 Validation
                            {
                                Console.WriteLine("Error! Please enter the numeric value of an option in the Trigonometry menu.");
                                Console.Write("Enter an option: ");
                                menuChoice2 = Console.ReadLine();
                            }                            
                        }
                    }
                    while(userChoice == "4");
                }                    

                //Implementing the Permutation feature
                else if (menuChoice1 == "3") //Case for Main menu option 3 
                {
                    do //do-while loop to execute the permutation feature while userChoice is 1
                    {
                        Console.Clear();
                        Console.WriteLine("**You have selected Permutation**\n");
                        Console.Write("Enter the value of n: ");
                        int nValue = GeneralMethods.CollectIntegerInput();
                        Console.Write("Enter the value of r: ");
                        int rValue = GeneralMethods.CollectIntegerInput();
                        var result = PermutationAndCombination.NPr(nValue, rValue);
                        userHistory.Add($"Permutation  |  ({nValue})P({rValue}) = {result}  |  {DateTime.Now}");
                        Console.WriteLine($"({nValue})P({rValue}) = {result}\n\n");
                        Console.Write("Enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                        userChoice = Console.ReadLine();

                        while (userChoice != "1" && userChoice != "2" && userChoice != "3") //userChoice validation
                        {
                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                    }
                    while (userChoice == "1");
                }

                //Implementing the Combination feature
                else if (menuChoice1 == "4") //Case for Main menu option 4
                {
                    do //do-while loop to execute the Combination feature while userChoice is 1
                    {
                        Console.Clear();
                        Console.WriteLine("**You have selected Combination**\n");
                        Console.Write("Enter the value of n: ");
                        int nValue = GeneralMethods.CollectIntegerInput();
                        Console.Write("Enter the value of r: ");
                        int rValue = GeneralMethods.CollectIntegerInput();
                        var result = PermutationAndCombination.NCr(nValue, rValue);
                        userHistory.Add($"Combination  |  ({nValue})C({rValue}) = {result}  |  {DateTime.Now}");
                        Console.WriteLine($"({nValue})C({rValue}) = {result}\n\n");
                        Console.Write("Enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                        userChoice = Console.ReadLine();

                        while (userChoice != "1" && userChoice != "2" && userChoice != "3") //userChoice validation
                        {
                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                    }
                    while (userChoice == "1");
                }

                //Implementing the Logarithm feature
                else if (menuChoice1 == "5") //Case for Main menu option 5
                {
                    do //do-while loop to execute the Logarithm feature while userChoice is 1
                    {
                        Console.Clear();
                        Console.WriteLine("**You have selected Logarithm**\n");
                        Console.Write("Enter value in base 10: ");
                        double numValue = GeneralMethods.CollectDoubleInput();
                        var result = Math.Log(numValue, 10);
                        userHistory.Add($"Logarithm  |  Log({numValue}) = {result}  |  {DateTime.Now}");
                        Console.WriteLine($"log({numValue}) = {result}\n\n");
                        Console.Write("Enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                        userChoice = Console.ReadLine();

                        while (userChoice != "1" && userChoice != "2" && userChoice != "3") //userChoice validation
                        {
                            Console.Write("Invalid entry! Please enter 1 to do another, 2 to return to main menu, or 3 to exit: ");
                            userChoice = Console.ReadLine();
                        }
                    }
                    while (userChoice == "1");
                }

                //Implementing the view-history feature
                else if (menuChoice1 == "6") //Case for Main menu option 6
                {
                    foreach (var item in userHistory) //loop to print out the instances in the arraylist
                    {
                        Console.WriteLine(item);
                    }
                    Console.Write("\nEnter 2 to return to main menu, or 3 to exit: ");
                    userChoice = Console.ReadLine();

                    while (userChoice != "2" && userChoice != "3") //userChoice validation
                    {
                        Console.Write("Invalid entry! Please enter 2 to return to main menu, or 3 to exit: ");
                        userChoice = Console.ReadLine();
                    }
                }

                else //Default case for Main menu options
                {
                    while (menuChoice1 != "1" && menuChoice1 != "2" && menuChoice1 != "3" && menuChoice1 != "4" && menuChoice1 != "5" && menuChoice1 != "6") //menuChoice1 validation
                    {
                        Console.WriteLine("Invalid entry. Please enter a valid option (1,2,3,4,5 or 6)");
                        Console.Write("Enter an option: ");
                        menuChoice1 = Console.ReadLine();
                    }
                }
            }
            while (userChoice == "2");
        }
    }
}
