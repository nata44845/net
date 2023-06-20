int[] array = { 38, 56, 45, 63, 28, 61, 53, 76, 22 };

int find = 45;

int i = 0;
int n = array.Length;
int index = -1;
while (i < n)
{
    if (array[i] == find)
    {
        index = i;
        break;
    }
    i = i + 1;
}

if (index == -1)
{
    Console.WriteLine("Элемент не найден");
}
else
{
    Console.Write("index = ");
    Console.WriteLine(index);
}
