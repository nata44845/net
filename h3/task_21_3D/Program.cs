// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double getDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Round(Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2)), 2);
    return dist;
}

//Ввод данных от пользователя
int x1 = getNum("Введите x1: ");
int y1 = getNum("Введите y1: ");
int z1 = getNum("Введите z1: ");
int x2 = getNum("Введите x2: ");
int y2 = getNum("Введите y2: ");
int z2 = getNum("Введите z2: ");

//Определить расстояние
double distance = getDist(x1, y1, z1, x2, y2, z2);

Console.WriteLine("Расстояние " + distance);
