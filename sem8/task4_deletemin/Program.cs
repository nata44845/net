// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetArray2D(int rows, int cols, int min, int max)
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
            Console.Write(String.Format("{0,3} ", array[i, j]));
        }
        Console.WriteLine();
    }
}


int[,] GetMinus(int[,] array)
{
    int sizeM = array.GetLength(0);
    int sizeN = array.GetLength(1);
    int min = array[0, 0];
    int minX = 0;
    int minY = 0;

    for (int i = 0; i < sizeM; i++)
    {
        for (int j = 0; j < sizeN; j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minX = j;
                minY = i;
            }
        }
    }
    int[,] arrayNew = new int[sizeM - 1, sizeN - 1];

    int ii = 0, jj = 0;
    for (int i = 0; i < sizeM; i++)
    {
        if (i == minY)
        {
            continue;
        }
        jj = 0;
        for (int j = 0; j < sizeN; j++)
        {
            if (j == minX)
            {
                continue;
            }
            arrayNew[ii, jj] = array[i, j];
            jj++;
        }
        ii++;
    }

    return arrayNew;
}

int sizeM = GetNum("Введите размер M: ");
int sizeN = GetNum("Введите размер N: ");

int[,] array = GetArray2D(sizeM, sizeN, 0, 9);

PrintArray2D(array);

Console.WriteLine();

int[,] arrayMin = GetMinus(array);


PrintArray2D(arrayMin);



