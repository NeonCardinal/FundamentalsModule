using System;

public class Division
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int greater = int.MinValue;
        bool isDiv = false;

        if(number % 2 == 0)
        {
            isDiv = true;
            greater = Math.Max(2, greater);
        }
        if(number % 3 == 0)
        {
            isDiv = true;
            greater = Math.Max(3, greater);
        }
        if(number % 6 == 0)
        {
            isDiv = true;
            greater = Math.Max(6, greater);
        }
        if(number % 7 == 0)
        {
            isDiv = true;
            greater = Math.Max(7, greater);
        }
        if(number % 10 == 0)
        {
            isDiv = true;
            greater = Math.Max(10, greater);
        }

        if(isDiv)
        {
            Console.WriteLine($"The number is divisible by {greater}");
        }
        else
        {
            Console.WriteLine("Not divisible");
        }
    }
}