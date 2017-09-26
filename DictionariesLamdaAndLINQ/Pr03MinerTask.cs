namespace Pr03MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr03MinerTask
    {
        static void Main()
        {
            var resourceType = Console.ReadLine();

            var elements = new Dictionary<string, int>();

            while (!resourceType.Equals("stop"))
            {
                var quantity = int.Parse(Console.ReadLine());

                if (!elements.ContainsKey(resourceType))
                {
                    elements[resourceType] = 0;
                }

                elements[resourceType] += quantity;

                resourceType = Console.ReadLine();
            }

            foreach (var kvp in elements)
            {
                var type = kvp.Key;
                var quantityTotal = kvp.Value;

                Console.WriteLine($"{type} -> {quantityTotal}");
            }
            //Console.ReadKey();
        }
    }
}
