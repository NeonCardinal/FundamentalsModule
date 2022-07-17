using System;
using System.Linq;

public class LadyBugs
{
    static void Main()
    {
        int fieldSIze = int.Parse(Console.ReadLine());
        int[] ladybugInit = new int[fieldSIze];
        int[] ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        foreach (var index in ladybugIndexes)
        {
            if (index >= 0 && index < ladybugInit.Length)
            {
                ladybugInit[index] = 1;
            }
        }

        string command = Console.ReadLine();

        while (command != "end")
        {
            string[] tokens = command.Split().ToArray();
            int index = int.Parse(tokens[0]);
            string direction = tokens[1];
            int power = int.Parse(tokens[2]);

            if ((index <= ladybugInit.Length - 1 && index >= 0) && ladybugInit[index] == 1)
            {
                if (direction == "right")
                {
                    ladybugInit[index] = 0;
                    Right(ladybugInit, index, power);
                }
                else if (direction == "left")
                {
                    ladybugInit[index] = 0;
                    Left(ladybugInit, index, power);
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(String.Join(" ", ladybugInit));
    }

    static void Right(int[] ladybugs, int bugIndex, int flyDir)
    {
        for(int i = 0; i < ladybugs.Length; i++)
        {
            if(bugIndex + flyDir + i > ladybugs.Length - 1 || bugIndex + flyDir + i < 0)
            {
                break;
            }

            if (ladybugs[bugIndex + flyDir + i] == 0)
            {
                ladybugs[bugIndex + flyDir + i] = 1;
                break;
            }
        }
    }

    static void Left(int[] ladybugs, int bugIndex, int flyDir)
    {
        for(int i = 0; i < ladybugs.Length; i++)
        {
            if (bugIndex - flyDir - i > ladybugs.Length - 1 || bugIndex - flyDir - i < 0)
            {
                break;
            }

            if (ladybugs[bugIndex - flyDir - i] == 0)
            {
                ladybugs[bugIndex - flyDir - i] = 1;
                break;
            }
        }
    }
}
