// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int EvenCount(int[] array)
{
    int len = array.Length;
    int even = 0;
    for (int i = 0; i < len; i++)
    {
        if (array[i] % 2 == 0) even += 1;
    }
    return even;
}

int size = GetNum("Введите количество элементов: ");

int[] array = GetArray(size, 100, 1000);

Console.WriteLine("[" + String.Join(", ", array) + "] -> " + Convert.ToString(EvenCount(array)));
