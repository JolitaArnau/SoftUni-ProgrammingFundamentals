namespace MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class MixedPhones
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var phoneBook = new SortedDictionary<string, long>();

            while (!line.Equals("Over"))
            {
                var entries = line.Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries);

                long phoneNumber = 0;

                if (long.TryParse(entries[0], out phoneNumber))
                {
                    phoneBook[entries[1]] = phoneNumber;
                }
                if (long.TryParse(entries[1], out phoneNumber))
                {
                    phoneBook[entries[0]] = phoneNumber;
                }

                line = Console.ReadLine();

            }

            foreach (var item in phoneBook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

    }
}
