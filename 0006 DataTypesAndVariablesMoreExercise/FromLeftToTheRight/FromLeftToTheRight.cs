using System;
using System.Linq;

public class FromLeftToTheRight
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            if(array[0] > array[1])
            {
                Console.WriteLine(Math.Abs(CalculateSum(array[0])));
            }
            else
            {
                Console.WriteLine(Math.Abs(CalculateSum(array[1])));
            }
        }
    }

    static long CalculateSum(long number)
    {
        long sum = 0;

        while(number != 0)
        {
            long temp = number % 10;
            sum += temp;
            number /= 10;
        }

        return sum;
    }
}