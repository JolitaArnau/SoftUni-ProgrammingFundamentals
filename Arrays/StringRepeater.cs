namespace StringRepeater
{
    using System;
    class StringRepeater
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            RepeatString(str, count);

        }

        static string RepeatString(string str, int count)
        {
            var repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString = str;

                Console.Write(repeatedString);
            }

            return repeatedString;
        }
    }
}
