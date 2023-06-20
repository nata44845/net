//Числа Фибоначчи

int fRec = 0;
int fIter = 0;

decimal FibonacciRec(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRec(n - 1) + FibonacciRec(n - 2);
}

decimal FibonacciIter(int n)
{
    fIter++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        (f0, f1) = (f1, f0 + f1);
        // result = f0 + f1;
        // f0 = f1;
        // f1 = f0 + result;
        fIter++;
    }
    return f1;
}

DateTime dt = DateTime.Now;
for (int i = 10; i < 40; i++)
{
    Console.WriteLine($"{i} => {FibonacciIter(i)} {fIter.ToString("### ### ###"),-15}");
    fIter = 0;
}
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();

dt = DateTime.Now;
for (int i = 10; i < 40; i++)
{
    Console.WriteLine($"{i} => {FibonacciRec(i)} {fRec.ToString("### ### ###"),-15}");
    fRec = 0;
}
Console.WriteLine((DateTime.Now-dt).TotalMilliseconds);
