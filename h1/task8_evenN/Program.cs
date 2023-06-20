// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int i=2;
while (i<N)
{
    Console.Write(i);
    if (i<N && i+1<N) Console.Write(", ");
    i+=2;
}

if (N>1 && N%2==0) Console.WriteLine(N);
