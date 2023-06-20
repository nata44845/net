// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
const int cellWidth = 3;

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintArray(int[,] matr)
{
    int rows = matr.GetLength(0);
    int cols = matr.GetLength(1);

    int col = cellWidth * rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if (matr[i, j] != 0) Console.Write($"{matr[i, j],cellWidth}");
            //if (matr[i, j] %2 != 0) Console.Write("*");
            col += cellWidth * 2;
        }
        col = cellWidth * rows - cellWidth * (i + 1);
        Console.WriteLine();
    }
}

void FillTriangle(int[,] triangle,int row)
{
    for (int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }

    for (int i = 2; i < row; i++)
    {
        for (int j = 1; j < row; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}

int num = GetNum("Введите количество строк: ");
int[,] triangle = new int[num, num];

Console.Clear();

FillTriangle(triangle,num);

PrintArray(triangle);
