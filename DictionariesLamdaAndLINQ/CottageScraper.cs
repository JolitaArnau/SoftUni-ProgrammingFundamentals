namespace CottageScaper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CottageScraper
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var allMaterials = new Dictionary<string, List<double>>();

            while (!line.Equals("chop chop"))
            {
                var cuttedTrees = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var type = cuttedTrees[0];
                var height = double.Parse(cuttedTrees[1]);

                if (!allMaterials.ContainsKey(type))
                {
                    allMaterials[type] = new List<double>();
                }

                allMaterials[type].Add(height);

                line = Console.ReadLine();
            }

            var requiredType = Console.ReadLine();
            var requiredHeight = double.Parse(Console.ReadLine());

            var usedMaterials = new Dictionary<string, List<double>>();

            double usedMaterialsSum = 0;

            if (allMaterials.ContainsKey(requiredType))
            {
                if (!usedMaterials.ContainsKey(requiredType))
                {
                    usedMaterials[requiredType] = new List<double>();
                }

                foreach (var tree in allMaterials)
                {
                    if (tree.Key.Equals(requiredType))
                    {
                        foreach (var height in tree.Value)
                        {
                            if (height >= requiredHeight)
                            {
                                usedMaterials[requiredType].Add(height);

                                usedMaterialsSum += height;
                            }
                        }
                    }

                }
            }

            double allMaterialsSum = 0.0;
            double allMaterialsCount = 0.0;

            foreach (var item in allMaterials)
            {
                foreach (var treeType in item.Value)
                {
                    allMaterialsSum += treeType;
                    allMaterialsCount++;

                }
            }

            double pricePerMeter = 0.01 * Math.Floor(100 * (allMaterialsSum / allMaterialsCount));

            double usedTreesPrice = usedMaterialsSum * pricePerMeter;

            double unusedMaterialsSum = 0.0;

            foreach (var unused in allMaterials)
            {

                foreach (var item in unused.Value)
                {
                    if (!unused.Key.Contains(requiredType) || item < requiredHeight)
                    {
                        unusedMaterialsSum += item;
                    }
                }
            }

            double percentUnused = 0.25;

            double unusedTreesPrice = (unusedMaterialsSum * pricePerMeter) * percentUnused;

            double subTotal = usedTreesPrice + unusedTreesPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedTreesPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unusedTreesPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${subTotal:f2}");

            Console.ReadKey();
        }

    }
}
