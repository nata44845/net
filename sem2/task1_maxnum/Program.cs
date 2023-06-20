int num = new Random().Next(10, 100);

int n1 = num/10;
int n2 = num%10;

if (n1>n2) 
{
    Console.WriteLine($"В числе {num} наибольшая цифра "+n1);
}
else
{
    Console.WriteLine($"В числе {num} наибольшая цифра "+n2);
}
