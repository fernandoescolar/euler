namespace ProjectEuler
{
    internal interface ISolver<T>
    {
        T Solve();
    }

    internal interface ISolver : ISolver<int>
    {
    }
}
