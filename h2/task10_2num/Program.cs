﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

if (n>999 || n<100)
{
    Console.WriteLine($"Число {n} не трехзначное");
}
else
{
    int num=n%100/10;
    Console.WriteLine($"Вторая цифра числа {n} равна "+num);
}