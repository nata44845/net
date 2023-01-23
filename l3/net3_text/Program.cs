string Replace(string text, char oldVal, char newVal)
{
    string result = String.Empty;
    int len = text.Length;
    for (int i = 0; i < len; i++)
    {
        if (text[i]==oldVal) result = result + $"{newVal}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string text = "– Я думаю, – сказал князь, улыбаясь, – что, ежели бы вас послали вместо нашего милого Винценгероде, "+
"вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

Console.WriteLine(text);
Console.WriteLine();

string res=Replace(text,' ','-');

Console.WriteLine(res);
Console.WriteLine();

res=Replace(res,'к','К');

Console.WriteLine(res);
Console.WriteLine();

res=Replace(res,'В','в');

Console.WriteLine(res);
