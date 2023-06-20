// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void checkPalindrom(int x)
{
    if (x / 10000 == x % 10 && (x % 10000) / 1000 == (x % 100) / 10) Console.WriteLine("да");
    else Console.WriteLine("нет");
}

//Ввод данных от пользователя
int num = getNum("Введите пятизначное число: ");

//Количество цифр
if (num >= 10000 && num < 100000) checkPalindrom(num);
else Console.WriteLine("Число не пятизначное");