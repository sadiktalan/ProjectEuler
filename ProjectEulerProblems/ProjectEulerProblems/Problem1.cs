using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerProblems
{
    class Problem1
    {
        public static int MultipliesOf3And5(int number)
        {
            var total = 0;
            var counter = 0;
            while (counter < number)
            {
                if (counter % 15 == 0)
                {
                    total += counter;
                }
                else if (counter % 5 == 0)
                {
                    total += counter;
                }
                else if (counter % 3 == 0)
                {
                    total += counter;
                }

                counter++;
            }

            return total;
        }
    }
}
