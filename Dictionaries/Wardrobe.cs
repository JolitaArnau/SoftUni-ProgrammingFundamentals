namespace Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Wardrobe
    {
        static void Main(string[] args)
        {

            var numberOfItems = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfItems; i++)
            {
                var colorAndType = Console.ReadLine()
                    .Split(new string[] { "->", " "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var color = colorAndType[0].Trim();
                var clothesSameColor = colorAndType[1].Split(',');

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                foreach (var piece in clothesSameColor)
                {
                    Dictionary<string, int> sameColor = wardrobe[color];

                    if (!sameColor.ContainsKey(piece))
                    {
                        sameColor[piece] = 0;
                    }

                    sameColor[piece]++;
                }
            }

            var searchInWardrobe = Console.ReadLine().Split();

            var searchColor = searchInWardrobe[0];
            var searchItem = searchInWardrobe[1];

            foreach (var kvp in wardrobe)
            {
                var color = kvp.Key;

                Console.WriteLine($"{color} clothes: ");

                foreach (var item in kvp.Value)
                {
                    var clothingPiece = item.Key;
                    var count = item.Value;

                    if (color.Equals(searchColor) && clothingPiece.Equals(searchItem))
                    {
                        Console.WriteLine($"* {clothingPiece} - {count} (found!)");
                    }

                    else
                    {
                        Console.WriteLine($"* {clothingPiece} - {count}");
                    }
                }
            }

            //Console.ReadKey();
        }
    }
}
