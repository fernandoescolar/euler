using System;

namespace ProjectEuler
{
    public class Solver10 : ISolver<long>
    {
        public long Solve()
        {
            return SumPrimesUntil(2000000);
        }

        long SumPrimesUntil(int limit)
        {
            var i = 3;
            long sum = 2;
            while (i < limit)
            {
                if (IsPrime(i))
                    sum += i;
                i += 2; 
            }
            return sum;
        }

        static bool IsPrime(int number)
        {
            if (number <= 3)
                return true;
            //if ((number & 1) == 0)
            //    return false;
            for (var i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }
    }
}