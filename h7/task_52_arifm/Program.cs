// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray(int rows, int cols, int min, int max)
{
    int[,] arr = new int[rows, cols];
    int maxTemp = max + 1;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = new Random().Next(min, maxTemp);
        }
    return arr;
}

void PrintArray2D(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(String.Format("{0,5} ", array[i, j]));
        }
        Console.WriteLine();
    }
}

///<summary>Среднее арифметическое в каждом столбце массива</summary>
double[] Arifmetical(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    double[] result = new double[cols];
    for (int j = 0; j < cols; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            result[j] += array[i, j];
        }
        result[j] = Math.Round(result[j] / rows, 2);
    }
    return result;
}


int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

int[,] array = GetArray(sizeM, sizeN, 0, 9);

PrintArray2D(array);

double[] arrayArifmetical = Arifmetical(array);

Console.WriteLine($"[{String.Join("; ", arrayArifmetical)}]");

