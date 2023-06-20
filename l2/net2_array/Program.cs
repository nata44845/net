int Max(int x, int y, int z)
{
    int result = x;
    if (y > result) result = y;
    if (z > result) result = z;
    return result;
}

int[] array = { 38, 56, 45, 63, 28, 61, 53, 76, 22 };



int max = array[0];
int i = 1;
int n = array.Length;
while (i < n)
{
    if (array[i] > max) max = array[i];
    i = i + 1;
}

Console.Write("max = ");
Console.WriteLine(max);

