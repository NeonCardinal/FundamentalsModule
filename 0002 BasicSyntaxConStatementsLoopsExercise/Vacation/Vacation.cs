using System;

public class Vacation
{
    static void Main()
    {
        int peopleCounter = int.Parse(Console.ReadLine());
        string groupType = Console.ReadLine();
        string day = Console.ReadLine();

        double totalPrice = 0.0;

        if(day == "Friday")
        {
            if(groupType == "Students")
            {
                if(peopleCounter >= 30)
                {
                    double discount = (peopleCounter * 8.45) * 0.15;
                    totalPrice = (peopleCounter * 8.45) - discount;
                }
                else
                {
                    totalPrice = peopleCounter * 8.45;
                }
            }
            else if(groupType == "Business")
            {
                if(peopleCounter >= 100)
                {
                    peopleCounter -= 10;
                    totalPrice = peopleCounter * 10.90;
                }
                else
                {
                    totalPrice = peopleCounter * 10.90;
                }
            }
            else if(groupType == "Regular")
            {
                if(peopleCounter >= 10 && peopleCounter <= 20)
                {
                    double discount = (peopleCounter * 15.0) * 0.05;
                    totalPrice = (peopleCounter * 15) - discount;
                }
                else
                {
                    totalPrice = peopleCounter * 15.0;
                }
            }
        }
        else if(day == "Saturday")
        {
            if (groupType == "Students")
            {
                if (peopleCounter >= 30)
                {
                    double discount = (peopleCounter * 9.80) * 0.15;
                    totalPrice = (peopleCounter * 9.80) - discount;
                }
                else
                {
                    totalPrice = peopleCounter * 9.80;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleCounter >= 100)
                {
                    peopleCounter -= 10;
                    totalPrice = peopleCounter * 15.60;
                }
                else
                {
                    totalPrice = peopleCounter * 15.60;
                }
            }
            else if (groupType == "Regular")
            {
                if (peopleCounter >= 10 && peopleCounter <= 20)
                {
                    double discount = (peopleCounter * 20) * 0.05;
                    totalPrice = (peopleCounter * 20) - discount;
                }
                else
                {
                    totalPrice = peopleCounter * 20;
                }
            }
        }
        else if(day == "Sunday")
        {
            if (groupType == "Students")
            {
                if (peopleCounter >= 30)
                {
                    double discount = (peopleCounter * 10.46) * 0.15;
                    totalPrice = (peopleCounter * 10.46) - discount;
                }
                else
                {
                    totalPrice = peopleCounter * 15;
                }
            }
            else if (groupType == "Business")
            {
                if (peopleCounter >= 100)
                {
                    peopleCounter -= 10;
                    totalPrice = peopleCounter * 16;
                }
                else
                {
                    totalPrice = peopleCounter * 16;
                }
            }
            else if (groupType == "Regular")
            {
                if (peopleCounter >= 10 && peopleCounter <= 20)
                {
                    double discount = (peopleCounter * 22.50) * 0.05;
                    totalPrice = (peopleCounter * 22.50) - discount;
                }
                else
                {
                    totalPrice = peopleCounter * 22.50;
                }
            }
        }

        if(totalPrice > 0.0)
        {
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}