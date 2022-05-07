using System;

public class BeerKegs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double greater = double.MinValue;
        string greaterModel = "";

        for(int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            if(volume > greater)
            {
                greater = volume;
                greaterModel = model;
            }
        }

        Console.WriteLine(greaterModel);
    }
}