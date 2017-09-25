using System;
using System.Linq;

namespace RotateArray
{
    class RotateArray
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var reordered = array.Skip(array.Length - 1).Concat(array.Take(array.Length - 1)).ToArray();
            foreach (var item in reordered)
            {
                Console.Write(item + " ");
            } 
        }
    }
}
