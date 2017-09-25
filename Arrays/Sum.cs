namespace Arrays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    class Sum
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            var sum = 0;

            for (int i= 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];
                
            }

            Console.WriteLine(sum);
        }
    }
}
