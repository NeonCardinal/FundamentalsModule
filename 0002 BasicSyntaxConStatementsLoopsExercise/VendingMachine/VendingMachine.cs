using System;

public class VendingMachine
{
    static void Main()
    {
        double sum = 0.0;

        while(true)
        {
            string command = Console.ReadLine().ToLower();

            if(command == "start")
            {
                break;
            }

            double coins = double.Parse(command);

            if(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
            {
                sum += coins;
            }
            else
            {
                Console.WriteLine($"Cannot accept {coins}");
            }
        }

        while(true)
        {
            string command = Console.ReadLine().ToLower();

            if(command == "end")
            {
                break;
            }

            if(command == "nuts")
            {
                if(sum >= 2.0)
                {
                    Console.WriteLine($"Purchased {command}");
                    sum -= 2.0;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(command == "water")
            {
                if (sum >= 0.7)
                {
                    Console.WriteLine($"Purchased {command}");
                    sum -= 0.7;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(command == "crisps")
            {
                if (sum >= 1.5)
                {
                    Console.WriteLine($"Purchased {command}");
                    sum -= 1.5;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(command == "soda")
            {
                if (sum >= 0.8)
                {
                    Console.WriteLine($"Purchased {command}");
                    sum -= 0.8;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else if(command == "coke")
            {
                if (sum >= 1.0)
                {
                    Console.WriteLine($"Purchased {command}");
                    sum -= 1.0;
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            else
            {
                Console.WriteLine("Invalid product");
            }
        }

        Console.WriteLine($"Change: {sum:F2}");
    }
}