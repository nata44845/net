//Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

//Вид 2
void Method2(string msg)
{
    Console.WriteLine("Автор " + msg);
}

//Method2("Иванов");


//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}

// int year=Method3();
// Console.WriteLine(year);

//Вид 4
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i=0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}

string res=Method4(10,"hi ");
Console.WriteLine(res);