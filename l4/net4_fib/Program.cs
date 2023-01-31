int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double Fib(int n)
{
    if (n == 1 || n == 2) return 1;
    else
    {
        return Fib(n - 1) + Fib(n - 2);
    }
}


int num = GetNum("Введите количество элементов: ");
for (int i = 1; i < 100; i++)
{
    Console.WriteLine($"{i} {Fib(i)}");
}