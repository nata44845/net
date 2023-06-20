// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int DiffMaxMin(int[] array)
{
    int len = array.Length;
    if (len == 0) return -1;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < len; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    return max - min;
}

int size = GetNum("Введите количество элементов: ");

int[] array = GetArray(size, 0, 100);

Console.WriteLine("[" + String.Join(", ", array) + "] -> " + Convert.ToString(DiffMaxMin(array)));