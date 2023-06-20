// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void printArray(int[] array)
{
    int len=array.Length;
    for (int i = 0; i < len-1; i++)
    {
       Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[len-1]} ");
}

int[] arr = new int[8];

for (int i = 0; i < 8; i++)
{
    arr[i] = new Random().Next(0, 2);
}

printArray(arr);