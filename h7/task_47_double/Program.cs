// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] GetArrayDouble(int rows, int cols, int min, int max)
{
    double[,] arr = new double[rows, cols];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        }
    return arr;
}

void PrintArray2D(double[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(String.Format("{0,7}", array[i, j]));
        }
        Console.WriteLine();
    }

}

int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

double[,] array = GetArrayDouble(sizeM, sizeN, 0, 100);

PrintArray2D(array);