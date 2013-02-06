using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    public class LinqSolver7 : ISolver
    {
        public int Solve()
        {
            return Enumerable.Range(2, int.MaxValue - 2).Where(IsPrime).Take(10001).Last();
        }

        static bool IsPrime(int n)
        {
            if (n <= 3)
                return true;
            if ((n & 1) == 0)
                return false;
            return !ForEnumeration(3, (int)Math.Sqrt(n), 2).Any(i => n % i == 0);
        }

        static IEnumerable<int> ForEnumeration(int from, int to, int step)
        {
            for (var i = from; i <= to; i += step)
                yield return i;
        }
    }
}