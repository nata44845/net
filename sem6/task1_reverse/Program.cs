// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

int[] ReverseArray(int[] array)
{
    int len = array.Length;
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[^(i+1)] = array[i];
    }
    return arr;
}

int size = GetNum("Введите количество элементов: ");

int[] array = GetArray(size,0,100);

Console.WriteLine(String.Join(", ",array));

int[] reverse = ReverseArray(array);

Console.WriteLine(String.Join(", ",reverse));