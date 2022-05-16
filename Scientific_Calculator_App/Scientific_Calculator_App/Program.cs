using System;

namespace Scientific_Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implementing initial Display Menu
            Console.WriteLine("***Welcome to George's Scientific calculator***\n\n" +
                "What would you like to do?\n" +
                "Please enter the numeric value of an option below to proceed\n" +
                "1. Addition\n" +
                "2. Subtraction\n" +
                "3. Multiplication\n" +
                "4. Division\n" +
                "5. Exponent\n" +
                "6. Trigonometry\n" +
                "7. Permutation\n" +
                "8. Combination\n" +
                "9. Logarithm\n");

            Console.Write("Enter a numeric Value:");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
