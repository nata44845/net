//Задача 51 сумма по диагонали

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

int GetSumArray(int[,] array)
{
    int sum = 0;
    int sizeM = array.GetLength(0);

    for (int i = 0; i < sizeM; i++)
        sum += array[i, i];

    return sum;
}


//Запросить размеры
int sizeM = GetNum("Введите размер массива: ");

int[,] array = GetArray2D(sizeM, sizeM, -9, 10);

PrintArray2D(array);

Console.WriteLine($"Сумма по диагонали {GetSumArray(array)}");


