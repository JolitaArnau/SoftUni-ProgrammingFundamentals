namespace DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DefaultValues
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var words = new Dictionary<string, string>();

            while (!line.Equals("end"))
            {
                var kvpSequence = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var key = kvpSequence[0];
                var value = kvpSequence[1];

                if (!words.ContainsKey(key))
                {
                    words[key] = value;
                }

                words[key] = value;

                line = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();




            var orderedByLength = words.OrderByDescending(w => w.Value.Length);

            foreach (var kvp in orderedByLength)
            {

                if (!kvp.Value.Contains("null"))
                {
                    Console.WriteLine($"{kvp.Key} <-> {kvp.Value}");
                }
            }


            foreach (var kvp in words)
            {
                if (kvp.Value.Contains("null"))
                {
                    var replaced = kvp.Value.Replace(kvp.Value, defaultValue);

                    Console.WriteLine($"{kvp.Key} <-> {replaced}");
                }

                
            }

            //Console.ReadKey();
        }
    }
}
