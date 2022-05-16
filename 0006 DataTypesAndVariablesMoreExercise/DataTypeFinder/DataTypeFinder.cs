using System;

public class DataTypeFinder
{
    static void Main()
    {
        while(true)
        {
            string cmd = Console.ReadLine();

            double floatNumber;
            int number;
            char ch;
            bool isBool;

            if(cmd == "END")
            {
                break;
            }

            if(int.TryParse(cmd, out number))
            {
                Console.WriteLine($"{cmd} is integer type");
            }
            else if(double.TryParse(cmd, out floatNumber))
            {
                Console.WriteLine($"{cmd} is floating point type");
            }
            else if(char.TryParse(cmd, out ch))
            {
                Console.WriteLine($"{cmd} is character type");
            }
            else if(bool.TryParse(cmd, out isBool))
            {
                Console.WriteLine($"{cmd} is boolean type");
            }
            else
            {
                Console.WriteLine($"{cmd} is string type");
            }
        }
    }
}