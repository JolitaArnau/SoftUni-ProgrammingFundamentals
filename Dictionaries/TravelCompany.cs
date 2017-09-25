 namespace TravelCompany
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TravelCompany
    {
        static void Main(string[] args)
        {
            var cityAndVehicleData = Console.ReadLine().Split(':');

            var destinationPackages = new Dictionary<string, Dictionary<string, int>>();

            while (!cityAndVehicleData[0].Equals("ready"))
            {
                var city = cityAndVehicleData[0];
                var typeAndCapacity = cityAndVehicleData[1].Split(',');

                if (!destinationPackages.ContainsKey(city))
                {
                    destinationPackages[city] = new Dictionary<string, int>();
                }


                for (int i = 0; i < typeAndCapacity.Length; i++)
                {
                    var currentTypeAndCapacity = typeAndCapacity[i].Split('-');
                    var type = currentTypeAndCapacity[0];
                    var capacity = int.Parse(currentTypeAndCapacity[1]);

                    if (!destinationPackages[city].ContainsKey(type))
                    {
                        destinationPackages[city].Add(type, capacity);
                    }
                    else
                    {
                        destinationPackages[city][type] = capacity;
                    }
                }

                cityAndVehicleData = Console.ReadLine().Split(':');
            }

            var destinationAndTouristsCount = Console.ReadLine().Split(' ');

            while (!destinationAndTouristsCount[0].Equals("travel"))
            {
                var destination = destinationAndTouristsCount[0];
                var travelersCount = int.Parse(destinationAndTouristsCount[1]);

                if (destinationPackages.ContainsKey(destination))
                {
                    var sumOfSeats = 0;

                    Dictionary<string, int> vehicles = destinationPackages[destination];

                    foreach (var vehicle in vehicles)
                    {
                        sumOfSeats += vehicle.Value;
                    }

                    if (travelersCount <= sumOfSeats)
                    {
                        Console.WriteLine($"{destination} -> all {travelersCount} accommodated");
                    }
                    else
                    {
                        var notAccommodated = travelersCount - sumOfSeats;

                        Console.WriteLine($"{destination} -> all except {notAccommodated} accommodated");
                    }
                }

                destinationAndTouristsCount = Console.ReadLine().Split(' ');
            }

            //Console.ReadKey();
        }
    }
}
