using System;

public class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int counter = 0;

        for(int i = 1; i <= 100; i += 2)
        {
            Console.WriteLine(i);
            sum += i;
            counter++;

            if(counter == n)
            {
                break;
            }
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
