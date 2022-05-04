using System;

public class RageExpenses
{
    static void Main()
    {
        //Receiving input data from the console
        int lostGames = int.Parse(Console.ReadLine());
        double headsetPrice = double.Parse(Console.ReadLine());
        double mousePrice = double.Parse(Console.ReadLine());
        double keyboardPrice = double.Parse(Console.ReadLine());
        double displayPrice = double.Parse(Console.ReadLine());

        //Some calculations here
        int trashedHeadsets = 0;
        int trashedMice = 0;
        int trashedKeyboards = 0;
        int trashedDisplays = 0;

        for (int i = 1; i <= lostGames; i++)
        {
            if (i % 2 == 0)
            {
                trashedHeadsets++;
            }
            if (i % 3 == 0)
            {
                trashedMice++;
            }
            if (i % 2 == 0 && i % 3 == 0)
            {
                trashedKeyboards++;
            }
        }

        for (int i = 1; i <= trashedKeyboards; i++)
        {
            if (i % 2 == 0)
            {
                trashedDisplays++;
            }
        }

        double sum = trashedHeadsets * headsetPrice + trashedMice * mousePrice + trashedKeyboards * keyboardPrice +
            trashedDisplays * displayPrice;

        Console.WriteLine($"Rage expenses: {sum:F2} lv.");
    }
}