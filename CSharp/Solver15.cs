using System.Numerics;

namespace ProjectEuler
{
    public class Solver15 : ISolver<ulong>
    {
        // combinatorias
        // http://es.wikipedia.org/wiki/Coeficiente_binomial
        public ulong Solve()
        {
            return Binomial(20);
        }

        static ulong Binomial(ulong x)
        {
            var numerator = Factorial(2*x);
            var denominatorPart = Factorial(x);
            return (ulong)(numerator / (denominatorPart * denominatorPart));
        }

        static BigInteger Factorial(ulong n)
        {
            return n == 1 ? 1 : n * Factorial(n - 1);
        }
    }
}