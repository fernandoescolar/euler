namespace ProjectEuler
{
    class Solver3 : ISolver
    {
        public int Solve()
        {
            return Calculate(600851475143, 2);
        }

        static int Calculate(long i, int divisor)
        {
            return (i == divisor) ? divisor : i%divisor == 0 ? Calculate(i/divisor, divisor) : Calculate(i, divisor + 1);
        }
    }
}
