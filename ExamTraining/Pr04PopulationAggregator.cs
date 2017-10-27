using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Pr04PopulationAggregator
{
    public class Pr04PopulationAggregator
    {
        public static void Main()
        {
            // top 3 cities ordered descending by population.Count city -> population
            // in case town comes twice, update 

            var line = Console.ReadLine();

            var country = string.Empty;
            var city = string.Empty;

            var countriesByCountOfCities = new SortedDictionary<string, int>();
            var citiesByPopulation = new Dictionary<string, long>();


            while (!line.Equals("stop"))
            {
                var populationData = line.Split('\\');

                long citiPopulation = long.Parse(populationData[2]);

                Regex forbiddenSymbols = new Regex(@"[^a-zA-Z]");

                if (char.IsUpper(populationData[0].First()))
                {
                    country = populationData[0];

                    Match match = forbiddenSymbols.Match(country);

                    if (match.Success)
                    {
                        country = forbiddenSymbols.Replace(country, "");
                    }

                    if (!countriesByCountOfCities.ContainsKey(country))
                    {
                        countriesByCountOfCities[country] = 0;
                    }
                    
                    countriesByCountOfCities[country]++;
                }

                if (char.IsUpper(populationData[1].First()))
                {
                    country = populationData[1];

                    Match match = forbiddenSymbols.Match(country);

                    if (match.Success)
                    {
                        country = forbiddenSymbols.Replace(country, "");
                    }

                    if (!countriesByCountOfCities.ContainsKey(country))
                    {
                        countriesByCountOfCities[country] = 0;
                    }
                    
                    countriesByCountOfCities[country]++;
                }

                if (char.IsLower(populationData[0].First()))
                {
                    city = populationData[0];

                    Match match = forbiddenSymbols.Match(city);

                    if (match.Success)
                    {
                        city = forbiddenSymbols.Replace(city, "");
                    }

                    if (!citiesByPopulation.ContainsKey(city))
                    {
                        citiesByPopulation[city] = citiPopulation;
                    }
                    citiesByPopulation[city] = citiPopulation;
                }

                if (char.IsLower(populationData[1].First()))
                {
                    city = populationData[1];

                    Match match = forbiddenSymbols.Match(city);

                    if (match.Success)
                    {
                        city = forbiddenSymbols.Replace(city, "");
                    }

                    if (!citiesByPopulation.ContainsKey(city))
                    {
                        citiesByPopulation[city] = citiPopulation;
                    }
                    citiesByPopulation[city] = citiPopulation;
                }


                line = Console.ReadLine();
            }

            foreach (var kvp in countriesByCountOfCities)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

            foreach (var kvp in citiesByPopulation.OrderByDescending(p => p.Value).Take(3))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}