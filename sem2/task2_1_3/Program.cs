int num = new Random().Next(100,1000000);

//num=100;
Console.WriteLine(num);

int num2 = num%10;

int num1 = num;

while (num1>=10)
{
    num1 = num1/10;
    Console.WriteLine(num1);
}

int res = num1*10+num2;

Console.WriteLine($"Число {num} -> "+res);

Console.WriteLine(res);

