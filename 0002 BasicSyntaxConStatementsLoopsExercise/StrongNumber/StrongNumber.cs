using System;

public class StrongNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int tempNumber = n;

        while(tempNumber > 0)
        {
            int currNumber = tempNumber % 10;
            tempNumber /= 10;
            int currFact = 1;

            for(int i = 1; i <= currNumber; i++)
            {
                currFact *= i;
            }

            sum += currFact;
        }

        if(n == sum)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}