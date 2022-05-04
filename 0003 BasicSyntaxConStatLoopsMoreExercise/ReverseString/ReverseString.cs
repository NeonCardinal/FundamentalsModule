using System;

public class ReverseString
{
    static void Main()
    {
        string str;

        str = Console.ReadLine();

        for (int i = str.Length - 1; i >= 0; i--)
        {
            Console.Write(str[i]);
        }

        Console.WriteLine();
    }
}
