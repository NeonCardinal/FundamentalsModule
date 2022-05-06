using System;

public class LowerOrUpper
{
    static void Main()
    {
        char ch = char.Parse(Console.ReadLine());

        if(char.IsUpper(ch))
        {
            Console.WriteLine("upper-case");
        }
        else
        {
            Console.WriteLine("lower-case");
        }
    }
}