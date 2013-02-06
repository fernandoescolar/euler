int calculate5(int i, int result)
{
    result = LeastCommonMultiple(result, i);
    return i == 20 ? result : calculate5( i + 1, result);
}

int GreatestCommonDivisor(int m, int n)
{
    int tmp = m; 
    m = n % m;
    n = tmp;
    return m == 0 ? n : GreatestCommonDivisor(m, n);
}

int LeastCommonMultiple(int m, int n)
{
    return m / GreatestCommonDivisor(m, n) * n;
}

int Solver5()
{
    return calculate5(1, 1);
}
