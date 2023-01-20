/*
квадрат одно для другого
*/

bool flag1 = false;
bool flag2 = false;

string numStr1 = null;
string numStr2 = null;

Console.Write("Введите число 1: ");
numStr1 = Console.ReadLine();
if (numStr1 !=null && numStr1 != "") flag1 = true;

if (flag1)
{
    Console.Write("Введите число 2: ");
    numStr2 = Console.ReadLine();
    if (numStr2 !=null && numStr2 != "") flag2 = true;
}

if (flag1 && flag2)
{
    int num1 = int.Parse(numStr1);
    int num2 = int.Parse(numStr2);

    if (num1 * num1== num2 || num2%num1 == 0)
    {
        Console.WriteLine("Да");
    }
    else 
    {
        Console.WriteLine("Нет");
    }

}
else
{
    Console.WriteLine("Неверный ввод данных!");
}
