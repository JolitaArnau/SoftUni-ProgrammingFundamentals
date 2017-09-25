namespace UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class UserLogins
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var logins = new Dictionary<string, string>();

            var userName = string.Empty;
            var password = string.Empty;



            while (!line.Equals("login"))
            {
                var userCredentials = line
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                userName = userCredentials[0];
                password = userCredentials[1];

                if (!logins.ContainsKey(userName))
                {
                    logins[userName] = password;
                }
                else
                {
                    logins[userName] = password;
                }

                line = Console.ReadLine();
            }

            int unsuccessfullLogins = 0;

            while (!line.Equals("end"))
            {

                if (!line.Equals("login"))
                {

                    var userInput = line
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                    var userNameInput = userInput[0];
                    var userPassInput = userInput[1];


                    if (logins.Keys.Contains(userNameInput) && logins.Values.Contains(userPassInput))
                    {
                        Console.WriteLine($"{userNameInput.Trim()}: logged in successfully");
                    }
                    else
                    {
                        Console.WriteLine($"{userNameInput.Trim()}: login failed");
                        unsuccessfullLogins++;
                    }
                }

                line = Console.ReadLine();

                if (line.Equals("end"))
                {
                    Console.WriteLine($"unsuccessful login attempts: {unsuccessfullLogins}");
                }

            }

            //Console.ReadKey();
        }
    }
}
