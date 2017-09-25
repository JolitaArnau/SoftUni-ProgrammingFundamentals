namespace RegisteredUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    class RegisteredUsers
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var registrations = new Dictionary<string, DateTime>();

            while (!line.Equals("end"))
            {
                var userStream = line.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                var userName = userStream[0];
                var dateRegistered = DateTime.ParseExact(userStream[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (!registrations.ContainsKey(userName))
                {
                    registrations[userName] = dateRegistered;
                }

                registrations[userName] = dateRegistered;

                line = Console.ReadLine();
            }


            var result = registrations
            .Reverse()
            .OrderBy(u => u.Value)
            .Take(5)
            .OrderByDescending(u => u.Value);
            foreach (var kvp in result)
            {
                Console.WriteLine(kvp.Key);
            }

            //Console.ReadKey();
        }
    }
}
