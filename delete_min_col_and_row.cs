
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых 
// расположен наименьший элемент массива.

int[,] CreateMatrix(int rows, int cols, int lowerBound, int upperBound)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(lowerBound, upperBound + 1);
        }
    }
    return matrix;
}
int GetNum(string text)
{
    Console.WriteLine(text);
    return int.Parse(Console.ReadLine());
}
void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write("{0,4}", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
int FindMinIndex(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int min = matrix[0, 0];
    int minIndex = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matrix[i,j] < min )
            {
                min = matrix[i, j];
                minIndex = i * cols + j;
            }
        }
    }
    return minIndex;
}
int[,] DeleteColAndRowByIndex(int[,] matrix, int minIndex)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int minCol = minIndex % cols;
    int minRow = minIndex / cols;
    int[,] newMatrix = new int[rows - 1, cols - 1];
    int ii=0,jj=0;
    // Console.WriteLine($"{minRow} {minCol} {matrix[minRow,minCol]}");
    for (int i = 0; i < rows; i++)
    {
        if(i == minRow){
            continue;
        }
        jj = 0;
        for (int j = 0; j < cols; j++)
        {
            if (j == minCol){
                continue;
            }
            newMatrix[ii, jj] = matrix[i, j];
            jj++;
        }
        ii++;
    }
    return newMatrix;
}


int n = 4;
int m = 4;
int[,] matrix = CreateMatrix(n, m, 0, 10);
ShowMatrix(matrix);
int minIndex = FindMinIndex(matrix);
int[,] newMatrix = DeleteColAndRowByIndex(matrix, minIndex);
ShowMatrix(newMatrix);

