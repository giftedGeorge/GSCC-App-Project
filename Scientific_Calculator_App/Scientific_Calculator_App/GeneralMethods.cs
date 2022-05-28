using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator_App
{
    internal class GeneralMethods
    {
        public static int CollectIntegerInput()
        {
            int intValue;
            while (!int.TryParse(Console.ReadLine(), out intValue))
                Console.WriteLine("Error! Please enter a valid integer value");
            return intValue;
        }

        public static double CollectDoubleInput()
        {
            double doubleValue;
            while (!double.TryParse(Console.ReadLine(), out doubleValue))
                Console.WriteLine("Error! Please enter a valid number value");
            return doubleValue;
        }

        public static double DegreesToRadians(double degreeValue)
        {
            return degreeValue * (Math.PI / 180.0);
        }

        public static double RadiansToDegrees(double radianValue)
        {
            return radianValue * (180.0 / Math.PI);
        }
    }
}
