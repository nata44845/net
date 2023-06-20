// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(int[] array)
{
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    if (len > 0) Console.Write($"{array[len - 1]}");
    Console.WriteLine("]");
}

//Ввод данных от пользователя
int num = GetNum("Введите количество элементов массива: ");

//Задать массив
int[] arr = new int[num];
int len = arr.Length;

for (int i = 0; i < len; i++)
{
    arr[i] = new Random().Next(0, 100);
}

PrintArray(arr);