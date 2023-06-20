// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void printCube(int num)
{
    int i = 1;
    while (i < num)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
        i++;
    }
    Console.Write($"{Math.Pow(num, 3)}");
}

//Ввод данных от пользователя
int num = getNum("Введите число: ");

//Вывести таблицу
printCube(num);
