using System;

public class EnglishNameOfTheLastDigit
{
    static void Main()
    {
        int number;

        number = int.Parse(Console.ReadLine());

        Console.WriteLine(DigitToText(number));
    }

    static string DigitToText(int number)
    {
        int digit = number % 10;
        string text = "";

        switch (digit)
        {
            case 0:
                {
                    text += "zero";
                }
                break;
            case 1:
                {
                    text += "one";
                }
                break;
            case 2:
                {
                    text += "two";
                }
                break;
            case 3:
                {
                    text += "three";
                }
                break;
            case 4:
                {
                    text += "four";
                }
                break;
            case 5:
                {
                    text += "five";
                }
                break;
            case 6:
                {
                    text += "six";
                }
                break;
            case 7:
                {
                    text += "seven";
                }
                break;
            case 8:
                {
                    text += "eight";
                }
                break;
            case 9:
                {
                    text += "nine";
                }
                break;
            default:
                break;
        }

        return text;
    }
}