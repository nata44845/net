// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int[] GetArray(int len, int min, int max)
{
    int[] arr = new int[len];
    int maxTemp = max + 1;
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, maxTemp);
    }
    return arr;
}

int[] GetMinusArray(int[] array)
{
    int len = array.Length;
    int[] arrReturn = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrReturn[i] = -array[i];
    }
    return arrReturn;
}

//Ввод данных от пользователя
int size = getNum("Введите размер массива: ");

//Задать массив
int[] arr = GetArray(size, -100, 100);

//Замена
int[] arrNew = GetMinusArray(arr);

//Печать массива 1
Console.WriteLine(String.Join(", ", arr));

//Печать массива 2
Console.WriteLine(String.Join(", ", arrNew));
