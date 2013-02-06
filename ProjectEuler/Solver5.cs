namespace ProjectEuler
{
    class Solver5 : ISolver
    {
        public int Solve()
        {
            return Calculate(1, 1);
        }

        static int Calculate(int i, int result)
        {
            result = LeastCommonMultiple(result, i);
            return i == 20 ? result : Calculate( i + 1, result);
        }

        static int GreatestCommonDivisor(int m, int n)
        {
            var tmp = m; 
            m = n % m;
            n = tmp;
            return m == 0 ? n : GreatestCommonDivisor(m, n);
        }

        static int LeastCommonMultiple(int m, int n)
        {
            return m / GreatestCommonDivisor(m, n) * n;
        }
    }
}
