
void PrintArray(int[,] matr)
{
    int rows=matr.GetLength(0);
    int cols=matr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    int rows=matr.GetLength(0);
    int cols=matr.GetLength(1);

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            matr[i,j] = new Random().Next(1,10);

}

string[,] table = new string[2, 3];
int[,] matrix = new int[3, 4];
table[1, 2] = "слово";
PrintArray(matrix);
FillArray(matrix);

Console.WriteLine();
PrintArray(matrix);