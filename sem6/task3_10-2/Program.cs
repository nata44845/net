// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string GetDouble(int num)
{
    string str="";
    while (num>0)
    {
        str=Convert.ToString(num%2)+str;
        num=num/2;
    }
    return str;
}

int num = GetNum("Введите число: ");

Console.WriteLine($"{num} -> {GetDouble(num)}");