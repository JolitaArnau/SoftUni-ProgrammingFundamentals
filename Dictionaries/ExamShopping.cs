namespace ExamShopping
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class ExamShopping
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var shop = new Dictionary<string, int>();

            var product = string.Empty;

            var command = string.Empty;

            var quantity = 0;

            while (!line.Equals("exam time"))
            {
                var stocking = line.Split();

                if (!line.Equals("shopping time"))
                {
                    command = stocking[0];
                    product = stocking[1];
                    quantity = int.Parse(stocking[2]);

                    if (command.Equals("stock"))
                    {
                        if (!shop.ContainsKey(product))
                        {
                            shop[product] = quantity;
                        }
                        else
                        {
                            shop[product] += quantity;
                        }
                    }
                    if (command.Equals("buy"))
                    {
                        if (!shop.ContainsKey(product))
                        {
                            Console.WriteLine($"{product} doesn't exist");
                        }

                        else if (shop.ContainsKey(product))
                        {
                            int stock = shop[product];

                            if (stock == 0)
                            {
                                Console.WriteLine($"{product} out of stock");
                            }

                            if (quantity > stock)
                            {
                                shop[product] = 0;
                            }

                            else
                            {
                                shop[product] -= quantity;
                            }
                        }
                    }
                }
                
               

                line = Console.ReadLine();
            }

            if (line.Equals("exam time"))
            {
                foreach (var productLeft in shop)
                {

                    if (productLeft.Value > 0)
                    {
                        Console.WriteLine($"{productLeft.Key} -> {productLeft.Value}");
                    }
                   
                }
            }
            //Console.ReadKey();
        }
    }
}
