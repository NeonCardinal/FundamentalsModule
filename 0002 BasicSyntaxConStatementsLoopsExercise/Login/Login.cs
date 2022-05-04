using System;

public class Login
{
    static void Main()
    {
        string username = Console.ReadLine();

        int counter = 0;
        string pass = string.Empty;

        for(int i = username.Length - 1; i >= 0; i--)
        {
            pass += username[i];
        }

        while(true)
        {
            string password = Console.ReadLine();

            if(pass == password)
            {
                Console.WriteLine($"User {username} logged in.");
                break;
            }
            else
            {
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
            }

            if(counter >= 3)
            {
                Console.WriteLine($"User {username} blocked!");
                break;
            }
        }
    }
}