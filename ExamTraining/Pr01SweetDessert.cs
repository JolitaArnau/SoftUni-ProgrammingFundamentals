using System;
using System.Collections.Generic;

namespace Pr01SweetDessert
{
    public class Pr01SweetDessert
    {
        public static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int guestes = int.Parse(Console.ReadLine());
            double singlePriceBananas = double.Parse(Console.ReadLine());
            double singlePriceEggs = double.Parse(Console.ReadLine());
            double kiloPriceBerries = double.Parse(Console.ReadLine());

            double portions = Math.Ceiling((double)guestes / 6);

            double moneyNeeded = portions * (2 * singlePriceBananas) + portions * (4 * singlePriceEggs) +
                                 portions * (0.2 * kiloPriceBerries);

            if (moneyNeeded > money)
            {
                double diff = moneyNeeded - money;

                Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:f2}lv more.");
            }
            
            else if (moneyNeeded <= money)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:f2}lv.");
            }
        }
    }
}