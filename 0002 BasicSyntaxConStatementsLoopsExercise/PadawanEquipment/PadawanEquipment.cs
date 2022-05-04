using System;

public class PadawanEquipment
{
    static void Main()
    {
        double amountOfMoney = double.Parse(Console.ReadLine());
        int studentsCounter = int.Parse(Console.ReadLine());
        double lightsaberPrice = double.Parse(Console.ReadLine());
        double robePrice = double.Parse(Console.ReadLine());
        double beltPrice = double.Parse(Console.ReadLine());

        double sum = 0.0;
        int freeBelt = 0;
        int extraPrice = (int)Math.Ceiling(studentsCounter * 0.10);
        double lightsaberCost = lightsaberPrice * (studentsCounter + extraPrice);
        double robesCost = studentsCounter * robePrice;

        for(int i = 1; i <= studentsCounter; i++)
        {
            if(i % 6 == 0)
            {
                freeBelt++;
            }
        }

        double beltCost = (studentsCounter - freeBelt) * beltPrice;
        sum = lightsaberCost + robesCost + beltCost;

        if(amountOfMoney >= sum)
        {
            Console.WriteLine($"The money is enough - it would cost {sum:F2}lv.");
        }
        else
        {
            Console.WriteLine($"John will need {(sum - amountOfMoney):F2}lv more.");
        }
    }
}