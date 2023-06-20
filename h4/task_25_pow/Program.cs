// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int Pow(int x, int y)
{
    int pow = 1;
    for (int i = 0; i < y; i++) pow = pow * x;
    return pow;
}

//Ввод данных от пользователя
int numA = GetNum("Введите число A: ");
int numB = GetNum("Введите число B: ");

//Степень
int pow = Pow(numA, numB);
Console.WriteLine($"{numA}, {numB} -> {pow}");