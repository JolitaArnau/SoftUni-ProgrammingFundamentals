namespace ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ForumTopics
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var forumTopicsData = new Dictionary<string, HashSet<string>>();

            while (!line.Equals("filter"))
            {
                var topicsAndTags = line
                    .Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var topic = topicsAndTags[0];
                var tags = topicsAndTags[1]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tags.Length; i++)
                {
                    var tag = tags[i];

                    if (!forumTopicsData.ContainsKey(topic))
                    {
                        forumTopicsData[topic] = new HashSet<string>();
                    }

                    forumTopicsData[topic].Add(tag);
                }

                line = Console.ReadLine();
            }

            if (line.Equals("filter"))
            {
                var searchForWords = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                var words = new List<string>();

                for (int i = 0; i < searchForWords.Length; i++)
                {
                    var word = searchForWords[i];
                    words.Add(word);
                }

                bool contains = false;

                foreach (var item in forumTopicsData)
                {
                    foreach (var word in words)
                    {
                        if (item.Value.Contains(word))
                        {
                            contains = true;
                        }
                    }
                }

                if (contains)
                {
                    foreach (var kvp in forumTopicsData)
                    {
                        Console.WriteLine($"{kvp.Key} | #{string.Join(", #", kvp.Value)}");
                    }
                }

            }

            //Console.ReadKey();
            
        }
    }
}
