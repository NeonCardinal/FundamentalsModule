using System;

public class RefactorSpecialNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSpecial = false;
        for (int i = 1; i <= number; i++)
        {
            int sum = 0;
            int digits = i;
            while (digits > 0)
            {
                sum += digits % 10;
                digits = digits / 10;
            }
            isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine("{0} -> {1}", i, isSpecial);
        }
    }
}
