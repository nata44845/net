int[,] pic = new int[1000,1000];
 for (int i = 0; i < 1000; i++)
 {
    pic[0,i]=1;
    pic[i,0]=1;
    pic[i,999]=1;
    pic[999,i]=1;
 }

void PrintArray(int[,] matr)
{
    int rows = matr.GetLength(0);
    int cols = matr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            if (matr[i, j] == 0) Console.Write("  ");
            else Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    // int rows = pic.GetLength(0);
    // int cols = pic.GetLength(1);

    if (pic[row,col]==0)
    {
        pic[row,col] = 8;
        FillImage(row-1, col);
        FillImage(row, col-1);
        FillImage(row+1, col);
        FillImage(row, col+1);
    }
}



//PrintArray(pic);

FillImage(1,1);
Console.WriteLine();

//PrintArray(pic);