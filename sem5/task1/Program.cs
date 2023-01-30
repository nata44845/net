// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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

void PrintArray(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[len - 1]} ");
}


int GetSum(int[] array, bool signPlus)
{
    int len = array.Length;
    int sum = 0;
    for (int i = 0; i < len - 1; i++)
    {
        if (signPlus && array[i] > 0 || !signPlus && array[i] < 0) sum += array[i];
    }
    return sum;
}

int[] GetTwoSumma(int[] array)
{
    int len = array.Length;
    int sumPlus = 0;
    int sumMinus = 0;
    for (int i = 0; i < len - 1; i++)
    {
        if (array[i] > 0) sumPlus += array[i];
        if (array[i] < 0) sumMinus += array[i];
    }
    int[] sum = { sumPlus, sumMinus };
    return sum;
}

//Задать массив
int[] arr = GetArray(12, -9, 9);

//Печать массива
Console.WriteLine(String.Join(", ", arr));

//Сумма положительных
int sumPlus = GetSum(arr, true);
Console.WriteLine($"Сумма положительных {sumPlus}");

//Сумма отрицательных
int sumMinus = GetSum(arr, false);
Console.WriteLine($"Сумма отрицательных {sumMinus}");


