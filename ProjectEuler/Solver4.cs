using System;

namespace ProjectEuler
{
    class Solver4 : ISolver
    {
        public int Solve()
        {
            return Calculate(999);
        }

        static int Calculate(int i)
        {
            return (i > 100) ? Math.Max(Calculate(i, i - 1), Calculate(i - 1)) : 0;
        }

        static int Calculate(int i, int j)
        {
            var product = i * j;
            return IsPalindrome(product) && i != j ? product : j > 100 ? Calculate(i, j - 1) : 0;
        }

        static bool IsPalindrome(int number)
        {
            var str = number.ToString();
            var charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return str == new string(charArray);
        }
    }
}
