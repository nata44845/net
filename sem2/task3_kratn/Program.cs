// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Write("Введите num1 = ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите num2 = ");
int num2 = int.Parse(Console.ReadLine());

int ost = num1%num2;

if (ost == 0)
{
        Console.WriteLine("Кратное");
}
{
        Console.WriteLine("Не кратное, "+ost);
}
