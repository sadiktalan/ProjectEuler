using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerProblems
{
    class Problem2
    {
        /**
         * From index 0; 
         * 1.,4.,7.,10., ... numbers will be even. 
         * */
        public static int SumOfEvenFibonacciNumbers(int upperLimit)
        {
            int fib1 = 1;
            int fib2 = 2;
            int sum = 0;
            while (fib2 < upperLimit)
            {
                if (fib2 % 2 == 0)
                    sum += fib2;
                int temp = fib2;
                fib2 += fib1;
                fib1 = temp;
            }
            return sum;
        }

    }
}
