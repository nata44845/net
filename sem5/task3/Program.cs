// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    int maxTemp = max + 1;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, maxTemp);
    }
    return arr;
}

bool NumInArray(int num,int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (num==array[i]) return true;
    }
    return false;
}

//Ввод данных от пользователя
int size = getNum("Введите размер массива: ");

//Ввод данных от пользователя
int num = getNum("Введите число, которое надо найти: ");

//Задать массив
int[] arr = GetArray(size, 0, 5);

//Печать массива
Console.WriteLine(String.Join(", ", arr));

//Поиск
Console.WriteLine(NumInArray(num,arr)?"да":"нет");


