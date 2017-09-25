using System;
using System.Linq;


namespace CountElements
{
    class CountElements
    {
        static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .ToCharArray();

            var reversed = elements.Reverse();

            if (elements == reversed)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
