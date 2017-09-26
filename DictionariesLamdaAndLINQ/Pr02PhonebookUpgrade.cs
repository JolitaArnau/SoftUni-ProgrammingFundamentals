namespace DictionariesLambdaAndLINQ
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr02PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

            var requests = Console.ReadLine().Split(' ');

            while (!requests.Equals("END"))
            {

                if (requests[0].Equals("A"))
                {

                    if (!phonebook.ContainsKey(requests[1]))
                    {
                        phonebook[requests[1]] = requests[2];
                    }
                    else
                    {
                        phonebook[requests[1]] = requests[2];

                    }
                }

                if (requests[0].Equals("S"))
                {
                    if (!phonebook.ContainsKey(requests[1]))
                    {
                        Console.WriteLine($"Contact {requests[1]} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{requests[1]} -> {requests[2]}");
                    }
                }

                if (requests[0].Equals("ListAll"))
                {
                    foreach (var entry in phonebook.Keys.OrderBy(x => x))
                    {
                        Console.WriteLine($"{entry} -> {phonebook[entry]}");
                    }
                }

                requests = Console.ReadLine().Split(' ');
            }
            Console.ReadKey();
        }
    }
}
