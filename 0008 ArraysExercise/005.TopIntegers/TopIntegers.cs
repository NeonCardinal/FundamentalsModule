using System;
using System.Linq;

public class TopIntegers
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string greater = "";

        for (int i = 0; i < array.Length; i++)
        {
            int currEl = array[i];
            bool isTopInteger = true;

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] >= currEl)
                {
                    isTopInteger = false;
                    break;
                }
            }

            if (isTopInteger)
            {
                greater += currEl + " ";
            }
        }

        Console.WriteLine(greater);
    }
}