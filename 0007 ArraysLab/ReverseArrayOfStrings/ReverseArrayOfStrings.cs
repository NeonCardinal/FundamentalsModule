﻿using System;
using System.Linq;

public class ReverseArrayOfStrings
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split();

        Array.Reverse(array);

        Console.WriteLine(string.Join(" ", array));
    }
}