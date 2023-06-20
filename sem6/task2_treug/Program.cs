// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int lenA = GetNum("Введите сторону A: ");
int lenB = GetNum("Введите сторону B: ");
int lenC = GetNum("Введите сторону C: ");

if (lenA < lenB + lenC && lenB < lenA + lenC && lenC < lenA + lenB)
    Console.WriteLine("Треугольник существует");
else Console.WriteLine("Треугольник не существует");