using System;

public class MetersToKilometers
{
    static void Main()
    {
        int meters = int.Parse(Console.ReadLine());

        decimal kilometers = meters / 1000.0M;

        Console.WriteLine($"{kilometers:F2}");
    }
}
