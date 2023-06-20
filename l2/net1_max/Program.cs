int Max(int x, int y, int z)
{
    int result = x;
    if (y > result) result = y;
    if (z > result) result = z;
    return result;
}

int a1 = 38;
int a2 = 56;
int a3 = 45;
int b1 = 63;
int b2 = 28;
int b3 = 61;
int c1 = 53;
int c2 = 76;
int c3 = 22;

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));

Console.Write("max = ");
Console.WriteLine(max);

