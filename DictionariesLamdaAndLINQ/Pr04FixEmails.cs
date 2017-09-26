namespace Pr04FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Pr04FixEmails
    {
        static void Main()
        {
            var name = Console.ReadLine();

            var validEmails = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                var email = Console.ReadLine();

                bool isValid = true;

                if (email.EndsWith("us") || email.EndsWith("uk"))
                {
                    isValid = false;
                }

                if (isValid == true)
                {
                    validEmails[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var user in validEmails)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }

            //Console.ReadKey();
        }
    }
}
