namespace Pr02TrophonTheGrumpyCat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Pr02TrophonTheGrumpyCat
    {
        public static void Main()
        {
            var priceRatings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var entryPoint = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var priceRating = Console.ReadLine();
            var leftSum = 0;
            var rightSum = 0;

            switch (type)
            {
                case "cheap":
                    if (priceRating.Equals("positive"))
                    {
                        CheapPositiveDamage(priceRatings, entryPoint, leftSum, rightSum);
                    }
                    if (priceRating.Equals("negative"))
                    {
                        CheapNegativeDamage(priceRatings, entryPoint, leftSum, rightSum);
                    }
                    if (priceRating.Equals("all"))
                    {
                        AllCheapDamage(priceRatings, entryPoint, leftSum, rightSum);
                    }
                    break;
                case "expensive":
                    if (priceRating.Equals("positive"))
                    {
                        ExpensivePositiveDamage(priceRatings, entryPoint, leftSum, rightSum);
                    }
                    if (priceRating.Equals("negative"))
                    {
                        ExpensiveNegativeDamage(priceRatings, entryPoint, leftSum, rightSum);
                    }
                    if (priceRating.Equals("all"))
                    {
                        AllExpensiveDamage(priceRatings, entryPoint, leftSum, rightSum);
                    }
                    break;
            }
        }

        private static void AllCheapDamage(List<int> priceRatings, int entryPoint, int leftSum, int rightSum)
        {
            for (int i = entryPoint; i < priceRatings.Count; i--)
            {
                if (i < 0)
                {
                    break;
                }

                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    leftSum += currentValue;
                }
            }

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    rightSum += currentValue;
                }
            }

            if (leftSum > rightSum || leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static void CheapNegativeDamage(List<int> priceRatings, int entryPoint, int leftSum, int rightSum)
        {
            for (int i = entryPoint; i < priceRatings.Count; i--)
            {
                if (i < 0)
                {
                    break;
                }

                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    if (currentValue < 0 && currentValue < valueOfEntryPoint)
                    {
                        leftSum += currentValue;
                    }
                }
            }

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    if (currentValue < 0 && currentValue < valueOfEntryPoint)
                    {
                        rightSum += currentValue;
                    }
                }
            }

            if (leftSum > rightSum || leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static void CheapPositiveDamage(List<int> priceRatings, int entryPoint, int leftSum, int rightSum)
        {
            for (int i = entryPoint; i < priceRatings.Count; i--)
            {
                if (i < 0)
                {
                    break;
                }

                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    if (currentValue > 0 && currentValue < valueOfEntryPoint)
                    {
                        leftSum += currentValue;
                    }
                }
            }

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    if (currentValue > 0 && currentValue < valueOfEntryPoint)
                    {
                        rightSum += currentValue;
                    }
                }
            }

            if (leftSum > rightSum || leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static void AllExpensiveDamage(List<int> priceRatings, int entryPoint, int leftSum, int rightSum)
        {
            for (int i = entryPoint; i < priceRatings.Count; i--)
            {
                if (i < 0)
                {
                    break;
                }

                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    leftSum += currentValue;
                }
            }

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    rightSum += currentValue;
                }
            }

            if (leftSum > rightSum || leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static void ExpensiveNegativeDamage(List<int> priceRatings, int entryPoint, int leftSum, int rightSum)
        {
            for (int i = entryPoint; i < priceRatings.Count; i--)
            {
                if (i < 0)
                {
                    break;
                }

                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != entryPoint)
                {
                    if (currentValue < 0 && currentValue >= valueOfEntryPoint)
                    {
                        leftSum += currentValue;
                    }
                }
            }

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != entryPoint)
                {
                    if (currentValue < 0 && currentValue >= valueOfEntryPoint)
                    {
                        rightSum += currentValue;
                    }
                }
            }

            if (leftSum > rightSum || leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }

        private static void ExpensivePositiveDamage(List<int> priceRatings, int entryPoint, int leftSum, int rightSum)
        {
            for (int i = entryPoint; i < priceRatings.Count; i--)
            {
                if (i < 0)
                {
                    break;
                }

                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != valueOfEntryPoint)
                {
                    if (currentValue > 0 && currentValue >= valueOfEntryPoint)
                    {
                        leftSum += currentValue;
                    }
                }
            }

            for (int i = entryPoint; i < priceRatings.Count; i++)
            {
                var currentValue = priceRatings[i];
                var valueOfEntryPoint = priceRatings[entryPoint];

                if (currentValue != entryPoint)
                {
                    if (currentValue > 0 && currentValue >= valueOfEntryPoint)
                    {
                        rightSum += currentValue;
                    }
                }
            }

            if (leftSum > rightSum || leftSum == rightSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
        }
    }
}