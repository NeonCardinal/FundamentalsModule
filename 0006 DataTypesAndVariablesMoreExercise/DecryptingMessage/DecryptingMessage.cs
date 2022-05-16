using System;

public class DecryptingMessage
{
    static void Main()
    {
        int key = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        string message = "";

        for (int i = 0; i < n; i++)
        {
            char symbol = char.Parse(Console.ReadLine());
            char result = (char)(symbol + key);
            message += result;
        }

        Console.WriteLine(message);
    }
}