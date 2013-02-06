int calculate2(int current, int next, int limit)
{
    return current > limit ? 0 : (current%2 == 0 ? current : 0) + calculate2(next, current + next, limit);
}

int Solver2()
{
	return calculate2(0, 1, 4000000);
}