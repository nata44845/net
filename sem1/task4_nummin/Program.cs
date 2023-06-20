Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

int i = -num;

while (i <= num)

{
    Console.Write(i);
    if (i < num) Console.Write(", ");
    i = i + 1;
}

