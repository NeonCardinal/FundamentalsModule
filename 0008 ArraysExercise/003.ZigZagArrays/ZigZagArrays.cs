using System;
using System.Linq;

public class ZigZagArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for(int i = 1; i <= n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if(i % 2 != 0)
            {
                firstArray[i - 1] = input[0];
                secondArray[i - 1] = input[1];
            }
            else
            {
                firstArray[i - 1] = input[1];
                secondArray[i - 1] = input[0];
            }
        }

        Console.WriteLine(string.Join(" ", firstArray));
        Console.WriteLine(string.Join(" ", secondArray));
    }
}