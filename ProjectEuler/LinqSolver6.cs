using System;
using System.Linq;

namespace ProjectEuler
{
    public class LinqSolver6 : ISolver
    {
        public int Solve()
        {
            var sumOfTheSquares = (int)Enumerable.Range(1, 100).Sum(i => Math.Pow(i, 2));
            var squareOfTheSum = (int)Math.Pow(Enumerable.Range(1, 100).Sum(), 2);
            return squareOfTheSum - sumOfTheSquares;
        }
    }
}