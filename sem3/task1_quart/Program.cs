// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void checkQuarter(int x, int y)
{
    int quot;
    if (x > 0 && y > 0) quot = 1;
    else if (x < 0 && y > 0) quot = 2;
    else if (x < 0 && y < 0) quot = 3;
    else quot = 4;
    Console.WriteLine("Четверть " + quot);
}

//Ввод данных от пользователя
int x = getNum("Введите x: ");
int y = getNum("Введите y: ");

//Определить четверть
checkQuarter(x, y);
