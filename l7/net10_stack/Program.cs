//переполнение стека
int i = 0;
void Rec()
{
    //Console.WriteLine(i++);
    Rec();
}

Rec();


