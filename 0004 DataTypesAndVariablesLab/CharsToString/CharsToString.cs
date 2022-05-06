using System;

public class CharsToString
{
    static void Main()
    {
        char a = char.Parse(Console.ReadLine());
        char b = char.Parse(Console.ReadLine());
        char c = char.Parse(Console.ReadLine());

        string str = string.Empty;
        str = "" + a + "" + b + "" + c;

        Console.WriteLine(str);
    }
}