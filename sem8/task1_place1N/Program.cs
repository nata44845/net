// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray2D(int rows, int cols, int min, int max)
{
    int[,] arr = new int[rows,cols];
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
            Console.Write("{0,3} ",array[i, j]);
        }
        Console.WriteLine();
    }

}

void Place1N(int[,] array)
{
    int len = array.GetLength(0);
    for(int j = 0; j< array.GetLength(1); j++)
    {
        (array[0,j], array[len-1,j]) = (array[len-1,j], array[0,j]);
    }
}

int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

int[,] array = GetArray2D(sizeM, sizeN, -99, 100);

PrintArray2D(array);

Place1N(array);
Console.WriteLine();

PrintArray2D(array);

