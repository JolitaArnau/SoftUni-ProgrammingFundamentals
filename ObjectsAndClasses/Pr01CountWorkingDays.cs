namespace Pr01CountWorkingDays
{
    using System;
    using System.Globalization;
    using System.Linq;

    class Pr01CountWorkingDays
    {
        public static void Main()
        {
            var startDateAsString = Console.ReadLine();
            var endDateAsString = Console.ReadLine();

            DateTime startDate = DateTime.ParseExact(startDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(endDateAsString, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];

            holidays[0] = new DateTime(4, 01, 01);
            holidays[1] = new DateTime(4, 03, 03);
            holidays[2] = new DateTime(4, 05, 01);
            holidays[3] = new DateTime(4, 05, 06);
            holidays[4] = new DateTime(4, 05, 24);
            holidays[5] = new DateTime(4, 09, 06);
            holidays[6] = new DateTime(4, 09, 22);
            holidays[7] = new DateTime(4, 11, 01);
            holidays[8] = new DateTime(4, 12, 24);
            holidays[9] = new DateTime(4, 12, 25);
            holidays[10] = new DateTime(4, 12, 26);


            var workingDaysCounter = 1;

            for (DateTime i = startDate; i < endDate; i = i.AddDays(1))
            {
                DayOfWeek currentDayOfWeek = i.DayOfWeek;

                DateTime temp = new DateTime(4, i.Month, i.Day);
                if (!holidays.Contains(temp) && (!currentDayOfWeek.Equals(DayOfWeek.Saturday) && !currentDayOfWeek.Equals(DayOfWeek.Sunday)))
                {
                    workingDaysCounter++;
                }
            }
            Console.WriteLine(workingDaysCounter);
        }
    }
}
