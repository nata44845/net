// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int getCompose(int num)
{
    int com = 1;
    for (int i = 1; i <= num; i++)
    {
        com = com * i;
    }
    return com;
}

//Ввод данных от пользователя
int number = getNum("Введите число: ");

//Найти сумму чисел
int compose = getCompose(number);

Console.WriteLine($"{number} -> {compose}");