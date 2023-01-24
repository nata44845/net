// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int getCount(int num)
{
    int i = 0;
    int temp = num;
    while (temp > 0)
    {
        temp = temp/10;
        i++;
    }
    return i;
}

//Ввод данных от пользователя
int number = getNum("Введите число: ");

//Найти сумму чисел
int count = getCount(number);

Console.WriteLine($"{number} -> {count}");