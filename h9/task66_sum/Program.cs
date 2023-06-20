// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int RecSum(int m, int n)
{
    if (n == m) return m;
    if (n < m) return m + RecSum(m - 1, n);
    else return n + RecSum(m, n - 1);
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");

int sum = RecSum(numM, numN);

Console.Write($"M = {numM}; N = {numN} -> {sum}");
