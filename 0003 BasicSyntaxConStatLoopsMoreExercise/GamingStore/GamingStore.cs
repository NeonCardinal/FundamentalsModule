using System;

public class GamingStore
{
    static void Main()
    {
        double money;
        double price;
        double spend;
        string command;

        price = 0;
        spend = 0;
        money = double.Parse(Console.ReadLine());

        while (true)
        {
            command = Console.ReadLine();

            if (command == "Game Time")
            {
                break;
            }

            if (command == "OutFall 4")
            {
                price = 39.99;
            }
            else if (command == "CS: OG")
            {
                price = 15.99;
            }
            else if (command == "Zplinter Zell")
            {
                price = 19.99;
            }
            else if (command == "Honored 2")
            {
                price = 59.99;
            }
            else if (command == "RoverWatch")
            {
                price = 29.99;
            }
            else if (command == "RoverWatch Origins Edition")
            {
                price = 39.99;
            }
            else
            {
                Console.WriteLine("Not Found");
                continue;
            }

            if (price > money)
            {
                Console.WriteLine("Too Expensive");
                continue;
            }

            money -= price;
            spend += price;

            Console.WriteLine($"Bought {command}");

            if (money == 0)
            {
                Console.WriteLine("Out of money!");
            }
        }

        Console.WriteLine($"Total spent: ${spend:F2}. Remaining: ${money:F2}");
    }
}