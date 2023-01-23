//Упорядочить массив по убыванию

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }

}


void SelectionSort(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count-1; i++)
    {
        int max = i;
        for (int j = i + 1; j < count; j++)
        {
            if (array[j] > array[max]) max = j;
        }
        int temp = array[i];
        array[i] = array[max];
        array[max] = temp;
    }
    PrintArray(array);
}


int[] arr = { 6, 8, 3, 2, 1, 4, 5, 7 };

PrintArray(arr);

Console.WriteLine();

SelectionSort(arr);
