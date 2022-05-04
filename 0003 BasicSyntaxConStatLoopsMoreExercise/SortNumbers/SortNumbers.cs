using System;

public class SortNumbers
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());
        int[] array = new int[3];

        array[0] = firstNumber;
        array[1] = secondNumber;
        array[2] = thirdNumber;

        Array.Sort(array);
        Array.Reverse(array);

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
