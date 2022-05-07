using System;

public class SpiceMustFlow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leaving = 0;
        int daysCounter = 0;
        int workersConsumation = 0;

        while(n >= 100)
        {
            daysCounter++;
            leaving += n;
            workersConsumation += 26;
            n -= 10;
            if(n < 100)
            {
                workersConsumation += 26;
            }
        }



        int totalLeavings = leaving - workersConsumation;

        Console.WriteLine(daysCounter);
        Console.WriteLine(totalLeavings);
    }
}