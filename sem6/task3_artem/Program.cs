// Преобразуйте десятичное число в двоичное

Console.Clear();

int[] ChangeToDouble(int num)
{
    int tempNum = num;
    int count = 0;
    while (tempNum != 0)
    {
        tempNum = tempNum / 2;
        count++;
    }
    int[] doubleArr = new int[count];
    for (int index = 0; index < count; index++)
    {
        doubleArr[index] = num % 2;
        num = num / 2;
    }
    return doubleArr;
}

int GetNum(string text)
{
    Console.WriteLine(text);
    int size = int.Parse(Console.ReadLine());
    return size;
}

int number = GetNum("Введите число для преобразования");
int[] array = ChangeToDouble(number);
Console.Write($"{number} -> ");
Console.WriteLine(String.Join("", array));