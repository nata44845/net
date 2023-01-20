

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double getDist(int x1, int y1, int x2, int y2)
{
    double dist = Math.Round(Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)),2);
    return dist;
}

//Ввод данных от пользователя
int x1 = getNum("Введите x1: ");
int y1 = getNum("Введите y1: ");
int x2 = getNum("Введите x2: ");
int y2 = getNum("Введите y3: ");

//Определить четверть
double distance = getDist(x1, y1, x2, y2);

Console.WriteLine("Расстояние "+distance);
