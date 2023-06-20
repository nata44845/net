// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[] OutFib(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i=2; i<num;i++)
        arr[i]=arr[i-1]+arr[i-2];
    return arr; 
}


int size = GetNum("Введите количество элементов: ");

int[] array = OutFib(size);

Console.WriteLine($"{String.Join(", ", array)}");

