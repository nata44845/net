// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных
//  координат точек в этой четверти (x и y).

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void checkXY(int quot)
{
    if (quot == 1) Console.WriteLine("x>0 y>0");
    if (quot == 2) Console.WriteLine("x<0 y>0");
    if (quot == 3) Console.WriteLine("x<0 y<0");
    if (quot == 4) Console.WriteLine("x>0 y<0");
}

//Ввод данных от пользователя
int quoter = getNum("Введите четверть: ");

//Определить x и y
checkXY(quoter);
