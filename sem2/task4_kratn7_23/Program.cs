/*
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
7 и 23.

14 -> нет 
46 -> нет 
161 -> да
*/

string? numberStr = null;

Console.Write("Введите число: ");
numberStr = Console.ReadLine();
if (numberStr != null && numberStr != "")
{
    int number = int.Parse(numberStr);
    int result1 = number % 7;
    int result2 = number % 23;
    if (result1 == 0 && result2 == 0)
    {
        Console.WriteLine($"Число {number} кратно числам одновременно 7 и 23");
    }
    else if (result1 == 0 && result2 != 0)
    {
        Console.WriteLine($"Число {number} кратно числу 7, но не кратно числу 23");
    }
    else if (result1 != 0 && result2 == 0)
    {
        Console.WriteLine($"Число {number} кратно числу 23, но не кратно числу 7");
    }
    else
    {
        Console.WriteLine($"Число {number} не кратно числам одновременно 7 и 23");
    }
}
else
{
    Console.WriteLine("Вы ничего не ввели в первое число!");
}
