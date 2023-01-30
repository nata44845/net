// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] GetArray(int size, int start, int finish)
{
    int[] emptyArray = new int[size];
    for (int index = 0; index < size; index++)
    {
        emptyArray[index] = new Random().Next(start, finish + 1);
    }
    return emptyArray;
}

int[] GetArr(int[] array)
{
    int size = array.Length;
    int[] emptyArray = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2; i++)
    {
        emptyArray[i] = array[i] * array[size - 1 - i];
    }
    if (size % 2 == 1) emptyArray[size / 2 + size % 2 - 1] = array[size / 2 + size % 2 - 1];
    return emptyArray;
}

// Генерируем массив
int[] array = GetArray(123, 0, 10);

Console.WriteLine(String.Join(", ", array));
int[] arr = GetArr(array);

Console.WriteLine(String.Join(", ", arr));