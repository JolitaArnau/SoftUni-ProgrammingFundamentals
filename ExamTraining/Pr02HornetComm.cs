using System.Collections.Generic;
using System.Linq;

namespace Pr02HornetComm
{
    using System;
    
    internal class Pr02HornetComm
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            
            var broadcasts = new List<string>();
            var privateMessages = new List<string>();
            
            while (!line.Equals("Hornet is Green"))
            {
                var queryPairs = line.Split(new string[] {" <-> "}, StringSplitOptions.RemoveEmptyEntries);
                var leftPart = queryPairs[0];
                var rightPart = queryPairs[1];

                var recipient = string.Empty;
                var message = string.Empty;
                var frequency = string.Empty;

                bool leftPartIsDigitsOnly = IsDigitsOnly(leftPart);
                bool rightPartIsDigitsAndLettersOnly = IsDigitsAndLetters(rightPart);
                
                if (leftPartIsDigitsOnly && rightPartIsDigitsAndLettersOnly)
                {
                   // is private 
                    leftPart = string.Join("", leftPart.Reverse());
                    recipient = leftPart;
                    message = rightPart;
                    privateMessages.Add(recipient + " -> " + message);

                }
                else if(rightPartIsDigitsAndLettersOnly)
                {
                    // is broadcast
                    message = leftPart;
                    frequency = rightPart;

                    var decryptedFrequency = string.Empty;
                  
                    foreach (char currentChar in frequency)
                    {
                        
                        //if char is uppercase transform to lowercase and if char is lowercase transform to uppercase
                        
                        if (currentChar >= 65 && currentChar <= 90)
                        {
                            decryptedFrequency += (char)(currentChar + 32);
                        }
                        else if (currentChar >= 97 && currentChar <= 122)
                        {
                            decryptedFrequency += (char)(currentChar - 32);
                        }
                        else
                        {
                            decryptedFrequency += currentChar;
                        }
                    }
                    frequency = decryptedFrequency;
                    
                    broadcasts.Add(frequency + " -> " + message);
                }
               
                line = Console.ReadLine();
            }

           

            if (broadcasts.Any())
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine(string.Join("\n", broadcasts));

            }
            if (privateMessages.Any())
            {
                Console.WriteLine("Messages:");
                Console.WriteLine(string.Join("\n", privateMessages));
            }
            
            if (!broadcasts.Any())
            {
                Console.WriteLine("Broadcasts:");
                Console.WriteLine("None");
            }
            
            if (!privateMessages.Any())
            {
                Console.WriteLine("Messages:");
                Console.WriteLine("None");
            }

        }
        
        //check if left part has digits only
        
        public static bool IsDigitsOnly(string leftPart)
        {
            foreach (char c in leftPart)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
        
        //check if right part has digits and letter only and no symbols or punctuation

        public static bool IsDigitsAndLetters(string rightPart)
        {
            bool isDigitsAndLetterssOnly = rightPart.All(c => Char.IsLetterOrDigit(c) && !Char.IsSymbol(c) && !Char.IsPunctuation(c));

            if (!isDigitsAndLetterssOnly)
            {
                return false;
            }

            return true;
        }
    }
}