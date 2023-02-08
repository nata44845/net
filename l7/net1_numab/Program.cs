string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i=a; i<=b; i++)
    {
        result+= $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a<=b) return $"{a} "+NumbersRec(a+1,b);
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1,5));
Console.WriteLine(NumbersRec(1,5));