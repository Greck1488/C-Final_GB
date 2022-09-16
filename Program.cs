string[] arrString = { };
int newArrayLength = 0;


Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Изначально заданный массив: ");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"{String.Join("; ",arrString )}");

for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length <= 3)
    {
        newArrayLength++;
    }
}


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Финальный массив с элементами, у которых три и меньше символов: ");

string[] newArray = new string[newArrayLength];
int k = 0;
for (int i = 0; i < arrString.Length; i++)
{
    if (arrString[i].Length <= 3)
    {
        newArray[k] = arrString[i];
        k++;
    }
}

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{String.Join("; ",newArray )}");
Console.ResetColor();
Console.ReadKey();
