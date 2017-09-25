
namespace TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            var blacklisted = Console.ReadLine().Split();

            var files = Console.ReadLine();

            var tracks = new List<string>();

            while (!files.Equals("end"))
            {
                files = Console.ReadLine();

                for (int i = 0; i < blacklisted.Length; i++)
                {
                    if (!files.Contains(blacklisted[i]) && !files.Contains("end"))
                    {
                        tracks.Add(files);
                    }
                }
            }

            var sorted = tracks.OrderBy(t => t);

            foreach (var track in sorted)
            {
                Console.WriteLine(track);
            }

            //Console.ReadKey();
        }
    }
}
