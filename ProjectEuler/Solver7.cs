using System;

namespace ProjectEuler
{
    public class Solver7 : ISolver
    {
        public int Solve()
        {
            return SearchPrime(10001);
        }

        int SearchPrime(int position)
        {
            var i = 3;
            position -= 2;
            while (position > 0)
            {
                i += 2;
                if (IsPrime(i))
                    position --;
                
            }
            return i;
        }

        static bool IsPrime(int number)
        {
            if (number <= 3)
                return true;
            if ((number & 1) == 0)
                return false;
            for (var i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if ((number % i) == 0)
                    return false;
            }
            return true;
        }

        // 2 seg.
        //static int SearchPrime(int position)
        //{
        //    int i = 1;
        //    while (position > 0)
        //    {
        //        if (IsPrime(++i))
        //            position--;
        //    }
        //    return i;
        //}

        //static bool IsPrime(int n)
        //{
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % i == 0 && i != n) return false;
        //    }
        //    return true;
        //}
    }
}