// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int getNum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void OutNumbers(int num)
{
    int i=1;
    while (i<num)
    {
        Console.Write(Math.Pow(i,2)+", ");
        i++;
    }
     Console.Write(Math.Pow(num,2));
}

//Ввод данных от пользователя
int number = getNum("Введите число: ");

//Определить x и y
OutNumbers(number);
