int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double Factorial(int n)
{
    if (n==1) return 1;
    else return n*Factorial(n-1);
}


int num = GetNum("Введите количество элементов: ");

Console.WriteLine(Factorial(num));