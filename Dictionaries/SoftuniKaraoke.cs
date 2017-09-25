namespace Mixed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SoftuniKaraoke
    {
        static void Main(string[] args)
        {
            var participants = Console.ReadLine()
                .Split(new char[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var avaliableSongs = Console.ReadLine()
                .Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToList();

            var karaokeRanking = new Dictionary<string, HashSet<string>>();

            var sequence = Console.ReadLine();

            while (!sequence.Equals("dawn"))
            {
                var tokens = sequence.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

                var nameParticipant = tokens[0];
                var performance = tokens[1];
                var award = tokens[2];

                sequence = Console.ReadLine();


                foreach (var song in avaliableSongs)
                {
                    if (song.Contains(performance) && participants.Contains(nameParticipant))
                    {
                        if (!karaokeRanking.ContainsKey(nameParticipant))
                        {
                            karaokeRanking[nameParticipant] = new HashSet<string>();
                        }

                        karaokeRanking[nameParticipant].Add(award);

                        if (!karaokeRanking[nameParticipant].Contains(award))
                        {
                            karaokeRanking[nameParticipant].Add(award);
                        }
                    }
                }
            }

            var ordered = karaokeRanking.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key);


            if (ordered.Any())
            {
                foreach (var participant in ordered)
                {
                    var name = participant.Key;
                    var countAwards = participant.Value.Count;
                    Console.WriteLine($"{name}: {countAwards} awards");

                    foreach (var award in participant.Value)
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }

            else
            {
                Console.WriteLine("No awards");
            }

            //Console.ReadKey();
        }
    }
}
