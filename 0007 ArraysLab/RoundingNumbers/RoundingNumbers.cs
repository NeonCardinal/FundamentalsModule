using System;
using System.Linq;

public class RoundingNumbers
{
    static void Main()
    {
        double[] array = Console.ReadLine().Split().Select(double.Parse).ToArray();
        int[] rounded = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            rounded[i] = (int)Math.Round(array[i], MidpointRounding.AwayFromZero);
        }

        for (int i = 0; i < rounded.Length; i++)
        {
            Console.WriteLine($"{array[i]} => {rounded[i]}");
        }
    }
}