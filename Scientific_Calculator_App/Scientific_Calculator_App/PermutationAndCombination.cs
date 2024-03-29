﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Scientific_Calculator_App
{
    public static class PermutationAndCombination
    {
        //Combination function
        public static BigInteger NCr(int n, int r)
        {
            return (Factorial(n) / (Factorial(r) * Factorial((n - r))));
        }

        //Permutation function
        public static BigInteger NPr(int n, int r)
        {
            return (Factorial(n) / Factorial((n - r)));
        }

        //Factorial function
        private static BigInteger Factorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                if (num <= 1)
                {
                    factorial = 1;
                }
                else 
                {
                    factorial *= i;
                }
            }
            return factorial;
        }

    }
}
