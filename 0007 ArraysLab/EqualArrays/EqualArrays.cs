using System;
using System.Linq;

public class EqualArrays
{
    static void Main()
    {
        bool notEqual = false;
        int sum = 0;
        int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                notEqual = true;
                break;
            }
            sum += firstArray[i];
        }

        if (!notEqual)
        {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}