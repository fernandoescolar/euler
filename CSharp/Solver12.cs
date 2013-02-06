using System;

namespace ProjectEuler
{
    public class Solver12 : ISolver<long>
    {
        // 1, 3, 6, 10, 15, 21, 28 ...
        public long Solve()
        {
            var result = 0;
            var index = 1;
            long number = 0;
            do
            {
                number += index++;
                result = CountDivisors(number);
            } while (result < 500);

            return number;
        }

        static int CountDivisors(long number)
        {
            var result = 0;
            var limit = (int)Math.Sqrt(number);
            for (var i = 1; i <= limit; i++)
            {
                if ((number % i) == 0)
                    result += 2; // i and number / i
            }

            if (limit * limit == number) result--; // if it is a perfect square pe 12x12 has one divisor repited
            return result;
        }
    }
}