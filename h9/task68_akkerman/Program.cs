// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int RecAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return (RecAkkerman(m - 1, 1));
    else return RecAkkerman(m - 1, RecAkkerman(m, n - 1));
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");

int akk = RecAkkerman(numM, numN);

Console.Write($"m = {numM}, n = {numN} -> A({numM},{numN}) = {akk}");