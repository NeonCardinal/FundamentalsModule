using System;

public class Orders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double total = 0.0;

        for (int i = 0; i < n; i++)
        {
            double capsulePrice = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int capsulesCount = int.Parse(Console.ReadLine());

            double sum = (days * capsulesCount) * capsulePrice;
            total += sum;

            Console.WriteLine($"The price for the coffee is: ${sum:F2}");
        }

        Console.WriteLine($"Total: ${total:F2}");
    }
}