using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scientific_Calculator_App
{
    internal class GeneralMethods
    {
        public static int collectIntegerInput()
        {
            int intValue = 0;
            while (!int.TryParse(Console.ReadLine(), out intValue))
                Console.WriteLine("Error! Please enter a valid integer value");
            return intValue;
        }

        public static double collectDoubleInput()
        {
            double doubleValue = 0;
            while (!double.TryParse(Console.ReadLine(), out doubleValue))
                Console.WriteLine("Error! Please enter a valid number value");
            return doubleValue;
        }


    }
}
