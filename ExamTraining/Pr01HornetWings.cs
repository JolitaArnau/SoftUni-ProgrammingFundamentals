namespace Pr01HornetWings
 {
     using System;
     public class Pr01HornetWings
     {
         public static void Main()
         {
             int wingFlaps = int.Parse(Console.ReadLine());
             decimal distancePerThousandFlaps = decimal.Parse(Console.ReadLine());
             int endurance = int.Parse(Console.ReadLine());
             
             //100 wing flaps per second
             // (2000 / 1000) * 5 = 2 * 5 = 10.00
 
             decimal totalDistance = (wingFlaps / 1000) * distancePerThousandFlaps;
             int totalTime = (wingFlaps / endurance) * 5 + (wingFlaps / 100);
 
             Console.WriteLine($"{totalDistance:f2} m.");
             Console.WriteLine($"{totalTime} s.");
         }
     }
 }