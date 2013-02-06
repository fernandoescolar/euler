using System;

namespace ProjectEuler
{
    public class Solver6 : ISolver
    {
        public int Solve()
        {
            return SquareOfTheSum(1, 0) - SumOfTheSquares(1, 0);
        }

        static int SumOfTheSquares(int i, int sum)
        {
            return i <= 100 ? SumOfTheSquares(i + 1, sum + (int)Math.Pow(i, 2)) : sum;
        }

        static int SquareOfTheSum(int i, int sum)
        {
            return i <= 100 ? SquareOfTheSum(i + 1, sum + i) : (int)Math.Pow(sum, 2);
        }
    }
}