using System;
using System.Linq;

public class KaminoFactory
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] dna = new int[n];
        int dnaLen = int.MinValue;
        int dnaIndex = int.MinValue;
        int dnaSum = int.MinValue;
        int dnaStart = -1;
        int index = 1;


        string command;

        while((command = Console.ReadLine()) != "Clone them!")
        {

            int[] data = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isTheOne = false;
            int currLen = int.MinValue;
            int currIndex = int.MinValue;
            int currSubLen = 0;
            int currSubIndex = 0;

            for(int i = 0; i < n; i++)
            {
                if (data[i] == 1 && isTheOne)
                {
                    currSubLen++;
                }
                else if (data[i] == 1)
                {
                    isTheOne = true;
                    currSubIndex = i;
                    currSubLen = 1;
                }
                else if (data[i] == 0 && isTheOne)
                {
                    if(currSubLen > currLen)
                    {
                        currLen = currSubLen;
                        currIndex = currSubIndex;
                    }

                    isTheOne = false;
                    currSubLen = 0;
                    currSubIndex = 0;
                }
            }

            if(isTheOne)
            {
                if(currSubLen > currLen)
                {
                    currLen = currSubLen;
                    currIndex = currSubIndex;
                }
            }

            if(currLen > dnaLen)
            {
                dnaLen = currLen;
                dnaIndex = currIndex;
                dnaSum = data.Sum();
                dna = data;
                dnaStart = index;
            }
            else if(currLen == dnaLen)
            {
                if(currIndex < dnaIndex)
                {
                    dnaLen = currLen;
                    dnaIndex = currIndex;
                    dnaSum = data.Sum();
                    dna = data;
                    dnaStart = index;
                }
                else if (currIndex == dnaIndex)
                {
                    if (data.Sum() > dnaSum)
                    {
                        dnaLen = currLen;
                        dnaIndex = currIndex;
                        dnaSum = data.Sum();
                        dna = data;
                        dnaStart = index;
                    }
                }
            }

            index++;
        }

        Console.WriteLine($"Best DNA sample {dnaStart} with sum: {dnaSum}.");
        Console.WriteLine(String.Join(" ", dna));
    }
}