// Задача 65: Задайте значения M и N. Напишите программу, которая выведет
//  все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

string Rec(int M, int N)
{
    if(N==M) return M.ToString();
    return M+", "+Rec(M+1,N);
}

int GetNum(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}
int numM = GetNum("Введите число M: ");
int numN = GetNum("Введите число N: ");

Console.WriteLine(Rec(numM, numN));
