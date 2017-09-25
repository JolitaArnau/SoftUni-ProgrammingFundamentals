namespace CitiesByContinentAndCountry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var allRegions = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

            for (int i = 0; i < n; i++)
            {
                var regions = Console.ReadLine().Split(' ');

                var continent = regions[0];
                var country = regions[1];
                var city = regions[2];

                if (!allRegions.ContainsKey(continent))
                {
                    allRegions[continent] = new SortedDictionary<string, SortedSet<string>>();

                }


                if (!allRegions[continent].ContainsKey(country))
                {
                    allRegions[continent][country] = new SortedSet<string>();

                }

                if (allRegions[continent].ContainsKey(country))
                {
                    allRegions[continent][country].Add(city);
                }
               
            }

            foreach (var region in allRegions)
            {
                var continent = region.Key;

                Console.WriteLine($"{continent}:");

                foreach (var country in region.Value)
                {
                    var countryName = country.Key;

                    Console.WriteLine($"    {countryName} -> {string.Join(", ", country.Value)}");
                }
            }

            //Console.ReadKey();
        }
    }
}
