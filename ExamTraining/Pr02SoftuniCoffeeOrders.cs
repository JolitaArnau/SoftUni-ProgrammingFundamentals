namespace Pr02SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;
    
    public class Pr02SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var countOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < countOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                var dateAsString = Console.ReadLine();
                DateTime date = DateTime.ParseExact(dateAsString, "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsulesCount = int.Parse(Console.ReadLine());
                int daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                decimal pricePerMonth = ((daysInMonth * capsulesCount) * pricePerCapsule);

                Console.WriteLine($"The price for the coffee is: ${pricePerMonth:f2}");

                totalPrice += pricePerMonth;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}