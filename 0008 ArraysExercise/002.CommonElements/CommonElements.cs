using System;

public class CommonElements
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split();
        string[] secondArray = Console.ReadLine().Split();
        string result = string.Empty;

        for(int i = 0; i < firstArray.Length; i++)
        {
            for(int j = 0; j < secondArray.Length; j++)
            {
                if (secondArray[j] == firstArray[i])
                {
                    result += secondArray[j] + " ";
                }
            }
        }
    }
}