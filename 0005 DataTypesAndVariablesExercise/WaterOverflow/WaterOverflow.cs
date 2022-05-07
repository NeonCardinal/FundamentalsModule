using System;

public class WaterOverflow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for(int i = 0; i < n; i++)
        {
            int litters = int.Parse(Console.ReadLine());

            if(litters > 255)
            {
                Console.WriteLine("Insufficient capacity");
            }
            else if(litters <= (255 - sum))
            {
                sum += litters;
            }
            else if(litters > (255 - sum))
            {
                Console.WriteLine("Insufficient capacity");
            }
        }

        Console.WriteLine(sum);
    }
}