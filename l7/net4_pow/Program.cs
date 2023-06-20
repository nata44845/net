int PowFor(int a, int b)
{
    int result = 1;
    for (int i=1; i<=b; i++)
    {
        result*= a;
    }
    return result;
}

int PowRec(int a,int b)
{
    if (b>1) return a*PowRec(a,b-1);
    else return a;
}

int PowRecMath(int a,int b)
{
    if (b==0) return 1;
    else if (b%2==0) return PowRecMath(a*a,b/2); 
    else return a*PowRec(a,b-1);
}

Console.WriteLine(PowFor(2,3));
Console.WriteLine(PowRec(2,3));
Console.WriteLine(PowRecMath(2,10));