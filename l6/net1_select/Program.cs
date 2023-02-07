using System.Linq;

string text = "(1,2) (2,3) (4,5) (5,6)"
        .Replace("(", "")
        .Replace(")", "");

var data = text.Split(" ")
        .Select(item => item.Split(","))
        .Select(e => (x: int.Parse(e[0]), y: int.Parse(e[1])))
        .Where(e => e.x % 2 == 0)
        .Select(point => (point.x * 10, point.y))
        .ToArray();

for (int i = 0; i < data.Length; i++)
{
    Console.WriteLine(data[i]);
}

///<summary>Метод</summary>
///<param name="n">Параметр</param>
///<returns>Возвращает</returns>

