using System;

public class SumDigits
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int sum = 0;

        while(number > 0)
        {
            int temp = number % 10;
            sum += temp;
            number /= 10;
        }

        Console.WriteLine(sum);
    }
}