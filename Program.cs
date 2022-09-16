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

