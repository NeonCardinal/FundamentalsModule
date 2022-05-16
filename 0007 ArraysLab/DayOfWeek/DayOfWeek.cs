using System;

public class DayOfWeek
{
    static void Main()
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        int n = int.Parse(Console.ReadLine());

        if(n < 1 || n > 7)
        {
            Console.WriteLine("Invalid day!");
        }
        else
        {
            n -= 1;
            Console.WriteLine(days[n]);
        }
    }
}