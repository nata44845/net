// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int RecPow(int a, int b)
{
  if (b == 0) return 1;
  return a * RecPow(a, b - 1);
}

int GetNum(string text)
{
  Console.Write(text);
  int num = int.Parse(Console.ReadLine());
  return num;
}

// Получение числа

int numA = GetNum("Введите число A: ");
int numB = GetNum("Введите число B: ");
Console.WriteLine(RecPow(numA, numB));