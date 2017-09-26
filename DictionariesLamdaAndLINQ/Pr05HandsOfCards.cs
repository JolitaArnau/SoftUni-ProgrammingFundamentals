namespace Pr05HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr05HandsOfCards
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var playersAndCards = new Dictionary<string, HashSet<string>>();

            var playersAndResults = new Dictionary<string, int>();


            while (!line.Equals("JOKER"))
            {
                var sequenceOfPlayersAndCards = line
                    .Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                var playerName = sequenceOfPlayersAndCards[0];

                var cards = sequenceOfPlayersAndCards[1]
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(c => c.Trim())
                    .ToList();

                if (!playersAndCards.ContainsKey(playerName))
                {
                    playersAndCards[playerName] = new HashSet<string>();

                    foreach (var card in cards)
                    {
                        playersAndCards[playerName].Add(card);
                    }
                }

                else
                {
                    foreach (var card in cards)
                    {
                        playersAndCards[playerName].Add(card);
                    }
                }

                line = Console.ReadLine();

                var totalValue = 0;

                if (line.Equals("JOKER"))
                {
                    foreach (var kvp in playersAndCards)
                    {
                        var playerNameFinal = kvp.Key;

                        foreach (var card in kvp.Value)
                        {

                            var powerAsString = string.Empty;
                            var typeAsString = string.Empty;


                            var powerValue = 0;
                            var typeValue = 0;

                            if (card.Length >= 3)
                            {
                                powerAsString = card[0].ToString() + card[1].ToString();
                                powerValue = int.Parse(powerAsString);

                                typeAsString = card[2].ToString();

                                if (typeAsString.Equals("S"))
                                {
                                    typeValue = 4;
                                }

                                if (typeAsString.Equals("H"))
                                {
                                    typeValue = 3;
                                }

                                if (typeAsString.Equals("D"))
                                {
                                    typeValue = 2;
                                }

                                if (typeAsString.Equals("C"))
                                {
                                    typeValue = 1;
                                }
                            }

                            else
                            {

                                powerAsString = card[0].ToString();
                                typeAsString = card[1].ToString();

                                if (powerAsString.Equals("2") || powerAsString.Equals("3") ||
                                    powerAsString.Equals("4") || powerAsString.Equals("5") ||
                                    powerAsString.Equals("6") || powerAsString.Equals("7") ||
                                    powerAsString.Equals("8") || powerAsString.Equals("9"))
                                {
                                    powerValue = int.Parse(powerAsString);
                                }

                                if (powerAsString.Equals("J"))
                                {
                                    powerValue = 11;
                                }

                                if (powerAsString.Equals("Q"))
                                {
                                    powerValue = 12;
                                }

                                if (powerAsString.Equals("K"))
                                {
                                    powerValue = 13;
                                }

                                if (powerAsString.Equals("A"))
                                {
                                    powerValue = 14;
                                }

                                if (typeAsString.Equals("S"))
                                {
                                    typeValue = 4;
                                }

                                if (typeAsString.Equals("H"))
                                {
                                    typeValue = 3;
                                }

                                if (typeAsString.Equals("D"))
                                {
                                    typeValue = 2;
                                }

                                if (typeAsString.Equals("C"))
                                {
                                    typeValue = 1;
                                }
                            }

                            totalValue += powerValue * typeValue;
                        }

                        if (!playersAndResults.ContainsKey(playerNameFinal))
                        {
                            playersAndResults[playerNameFinal] = totalValue;
                        }

                    }
                }
            }

            foreach (var player in playersAndResults)
            {
                var name = player.Key;
                var value = player.Value;

                Console.WriteLine($"{name}: {value}");
            }

            //Console.ReadKey();
        }
    }
}
