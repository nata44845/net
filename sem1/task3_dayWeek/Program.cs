Console.WriteLine("Введите число ");
int num = int.Parse(Console.ReadLine());

string day = "День не определен";

if (num == 1) day = "Понедельник";
if (num == 2) day = "Вторник";
if (num == 3) day = "Среда";
if (num == 4) day = "Четверг";
if (num == 5) day = "Пятница";
if (num == 6) day = "Суббота";
if (num == 7) day = "Воскресенье";

Console.Write(day);
