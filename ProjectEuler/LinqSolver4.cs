using System;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler
{
    class LinqSolver4 : ISolver
    {
        public int Solve()
        {
            return Calculate(100, 999);
        }

        static int Calculate(int start, int end)
        {
            var a = Enumerable.Range(start, end - start);
            var b = Enumerable.Range(start, end - start);
            return (from x in a
                   from y in b
                   where x != y
                    select x  *y).Where(IsPalindrome).Max();
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
