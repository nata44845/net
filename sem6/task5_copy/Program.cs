//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int GetNum(string text)
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

int[] CopyArray(int[] array)
{
    int len = array.Length;
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

int size = GetNum("Введите количество элементов: ");

int[] array = GetArray(size,0,100);

Console.WriteLine(String.Join(", ",array));

int[] copyArray = CopyArray(array);

Console.WriteLine(String.Join(", ",copyArray));