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
                "6. View History");

            Console.Write("Enter a numeric Value:");
            int menuChoice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
