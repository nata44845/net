// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetArray(int size, int start, int finish)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(start, finish + 1);
    }
    return emptyArray;
}

int[] GetCount1099(int[] array)
{
    int size = array.Length;
    int[] emptyArray = new int[size];
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] >= 10 || array[i] < 100)
        {
            emptyArray[j] = array[i];
            j++;
        }
    }
    return emptyArray;
}

// Генерируем массив
int[] array = GetArray(10, 0, 1000);

Console.WriteLine(String.Join(", ", array));

int[] arr = GetCount1099(array);

Console.WriteLine(String.Join(", ", arr));
