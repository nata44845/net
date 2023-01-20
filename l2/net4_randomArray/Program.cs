void FillArray(int[] collection)
{
    int n = collection.Length;
    int i = 0;
    while (i < n)
    {
        collection[i] = new Random().Next(1, 10);
        i = i + 1;
    }
}

void PrintArray(int[] col)
{
    int n = col.Length;
    int i = 0;
    while (i < n)
    {
        Console.WriteLine(col[i]);
        i++;
    }
}

int IndexOf(int[] col, int find)
{
    int i = 0;
    int n = col.Length;
    int index = -1;
    while (i < n)
    {
        if (col[i] == find)
        {
            index = i;
            break;
        }
        i = i + 1;
    }
    return index;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine("index = " + IndexOf(array, 4));



