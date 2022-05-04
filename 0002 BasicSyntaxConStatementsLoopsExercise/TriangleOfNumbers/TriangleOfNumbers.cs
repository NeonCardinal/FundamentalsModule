using System;

public class TriangleOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int number = 1;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < number; j++)
            {
                Console.Write($"{number} ");
            }

            number++;
            Console.WriteLine();
        }
    }
}