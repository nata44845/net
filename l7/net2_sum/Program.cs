int SumFor(int n)
{
    int result = 0;
    for (int i=1; i<=n; i++)
    {
        result+= i;
    }
    return result;
}

int SumRec(int n)
{
    if (n>=1) return n+SumRec(n-1);
    else return 0;
}

Console.WriteLine(SumFor(1));
Console.WriteLine(SumRec(1));