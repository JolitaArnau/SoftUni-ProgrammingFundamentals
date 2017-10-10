namespace Pr09LegendaryFarming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Pr09LegendaryFarming
    {
        static void Main()
        {

            var keyMaterials = new Dictionary<string, int>();
            var junkMaterials = new Dictionary<string, int>();

            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);

            CollectMaterials(keyMaterials, junkMaterials);

            Console.WriteLine($"{ObtainLegendaryItem(keyMaterials)} obtained!");

            PrintRemainingKeyMaterials(keyMaterials);

            PrintJunkMaterials(junkMaterials);

            Console.ReadKey();

        }
        private static void PrintJunkMaterials(Dictionary<string, int> junkMaterials)
        {

            foreach (var material in junkMaterials.OrderBy(m => m.Key))
            { 
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
        private static void PrintRemainingKeyMaterials(Dictionary<string, int> keyMaterials)
        {

            foreach (var material in keyMaterials.OrderByDescending(m => m.Value).ThenBy(q => q.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        private static string ObtainLegendaryItem(Dictionary<string, int> keyMaterials)
        {
            var materialName = keyMaterials
                .Where(kvp => kvp.Value >= 250)
                .First()
                .Key;

            keyMaterials[materialName] -= 250;

            switch (materialName)
            {
                case "shards":
                    return "Shadowmourne";
                case "fragments":
                    return "Valanyr";
                case "motes":
                    return "Dragonwrath";
                default:
                    return "Nothing obtained";
            }
        }

        private static void CollectMaterials(Dictionary<string, int> keyMaterials, Dictionary<string, int> junkMaterials)
        {
            while (true)
            {
                var pairs = Console.ReadLine()
                    .ToLower()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < pairs.Length; i++)
                {
                    var quantity = int.Parse(pairs[i]);
                    i++;
                    var material = pairs[i];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            return;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }
        }
    }
}