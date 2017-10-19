namespace Pr02PokeMonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Pr02PokeMonDontGo
    {
        static void Main()
        {
            var distances = Console.ReadLine().Split().Select(int.Parse).ToList();
            var removedValue = 0;

            long sum = 0;

            while (distances.Count > 0)
            {

                if (!distances.Any())
                {
                    break;
                }

                var index = int.Parse(Console.ReadLine());
                
                if (index >= distances.Count)
                {
                    removedValue = distances.Last();
                    distances.RemoveAt(distances.Count - 1);
                    var firstElement = distances.First();
                    distances.Add(firstElement);

                    sum += removedValue;

                }


                else if (index < 0)
                {
                    removedValue = distances.First();
                    distances.RemoveAt(distances.First());
                    distances.Insert(0, distances.Last());

                    sum += removedValue;

                }

                else
                {
                    removedValue = distances[index];
                    distances.RemoveAt(index);

                    sum += removedValue;
                }

                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] <= removedValue)
                    {
                        distances[i] += removedValue;
                    }

                    else
                    {
                        distances[i] -= removedValue;
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
