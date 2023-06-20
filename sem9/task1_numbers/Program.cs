// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int Rec(int n)
{
    if (n==0) return 1;
    Console.Write($"{Rec(n-1)} ");
    return n+1;
}

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int num = GetNum("Введите число N: ");
Rec(num);