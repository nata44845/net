int FactorialFor(int n)
{
    int result = 1;
    for (int i=1; i<=n; i++)
    {
        result*= i;
    }
    return result;
}

int FactorialRec(int n)
{
    if (n>1) return n*FactorialRec(n-1);
    else return 1;
}

Console.WriteLine(FactorialFor(0));
Console.WriteLine(FactorialRec(0));