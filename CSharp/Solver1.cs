namespace ProjectEuler
{
    class Solver1 : ISolver
    {
        public int Solve()
        {
            return Calculate(1, 1000);
        }

        static int Calculate(int i, int limit)
        {
            return (i >= limit) ? 0 : ((i % 3 == 0 || i % 5 == 0) ? i : 0) + Calculate(i + 1, limit);
        }
    }
}
