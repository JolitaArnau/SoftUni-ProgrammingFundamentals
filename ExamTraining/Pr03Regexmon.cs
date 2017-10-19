namespace Pr03Regexmon
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    class Pr03Regexmon
    {
        static void Main()
        {
            var regexmon = Console.ReadLine();

            while (true)
            {
                Regex bojomon = new Regex(@"[a-zA-Z}]+-[a-zA-Z]+"); 
                Regex didimon = new Regex(@"[^a-zA-Z-]+");


                Match didimonMatch = didimon.Match(regexmon);

                if (didimonMatch.Success)
                {
                    Console.WriteLine(didimonMatch);
                    
                }

                else
                {
                    return; 
                }

                var didiMonStart = didimonMatch.Index;
                regexmon = regexmon.Substring(didiMonStart + didimonMatch.Length);

                Match bojomonMatch = bojomon.Match(regexmon);

                if (bojomonMatch.Success)
                {
                    Console.WriteLine(bojomonMatch);
                }

                else
                {
                    return;
                }

                var bojomonStart = bojomonMatch.Index;
                regexmon = regexmon.Substring(bojomonStart + bojomonMatch.Length);
            }

        }
    }
}
