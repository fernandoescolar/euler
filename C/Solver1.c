int calculate1(int i, int limit)
{
    return (i >= limit) ? 0 : ((i % 3 == 0 || i % 5 == 0) ? i : 0) + calculate1(i + 1, limit);
}

int Solver1()
{
	return calculate1(1, 1000);
}
        