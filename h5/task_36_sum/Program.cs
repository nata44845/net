// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int OddPosSum(int[] array)
{
    int len = array.Length;
    int sum = 0;
    for (int i = 1; i < len; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int size = GetNum("Введите количество элементов: ");

int[] array = GetArray(size, -100, 101);

Console.WriteLine("[" + String.Join(", ", array) + "] -> " + Convert.ToString(OddPosSum(array)));