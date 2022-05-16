using System;

public class FloatingEquality
{
    static void Main()
    {
        const double Eps = 0.000001;
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double result = Math.Abs(a - b);

        if (result > Eps)
        {
            Console.WriteLine("False");
        }
        else if (result < Eps)
        {
            Console.WriteLine("True");
        }
        else if (result == Eps)
        {
            Console.WriteLine("False");
        }
    }
}