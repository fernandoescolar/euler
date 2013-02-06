namespace ProjectEuler
{
    public class Solver2 : ISolver
    {
        public int Solve()
        {
            return Calculate(0, 1, 4000000);
        }

        static int Calculate(int current, int next, int limit)
        {
            return current > limit ? 0 : (current%2 == 0 ? current : 0) + Calculate(next, current + next, limit);
        }
    }
}
