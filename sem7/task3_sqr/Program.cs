// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

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
            Console.Write(String.Format("{0,3} ", array[i, j]));
        }
        Console.WriteLine();
    }

}


void SqrArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 1; i < rows; i+=2)
    {
        for (int j = 1; j < cols; j+=2)
        {
            array[i,j]=array[i,j]*array[i,j];
        }
        Console.WriteLine();
    }

}

//Запросить размеры
int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

int[,] array = GetArray2D(sizeM, sizeN, -9, 10);

PrintArray2D(array);

SqrArray(array);

PrintArray2D(array);
