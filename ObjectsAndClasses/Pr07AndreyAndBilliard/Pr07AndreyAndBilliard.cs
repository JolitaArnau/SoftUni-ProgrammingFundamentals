namespace Pr07AndreyAndBilliard
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class Pr07AndreyAndBilliard
    {
        public static void Main()
        {
            int countOfEntities = int.Parse(Console.ReadLine());

            var shop = new Dictionary<string, decimal>();

            for (int i = 0; i < countOfEntities; i++)
            {
                var currentEntity = Console.ReadLine().Split('-').ToList();

                var product = currentEntity[0];
                var productPrice = decimal.Parse(currentEntity[1]);

                if (!shop.ContainsKey(product))
                {
                    shop[product] = productPrice;
                }
                else
                {
                    shop[product] = productPrice;
                }
            }

            var orders = Console.ReadLine();

            Customer customer = new Customer();

            var shoppingList = customer.ShoppingList = new Dictionary<string, Dictionary<string, int>>();

            while (!orders.Equals("end of clients"))
            {
                var currentOrder = orders.Split(new char[] { '-', ',' }).ToList();
                var currentCustomerName = currentOrder[0];
                var currentOrderProduct = currentOrder[1];
                var currentProductQuantity = int.Parse(currentOrder[2]);


                if (shop.ContainsKey(currentOrderProduct))
                {
                    if (!shoppingList.ContainsKey(currentCustomerName))
                    {
                        shoppingList[currentCustomerName] = new Dictionary<string, int>();

                        if (!shoppingList[currentCustomerName].ContainsKey(currentOrderProduct))
                        {
                            shoppingList[currentCustomerName][currentOrderProduct] = currentProductQuantity;
                            
                        }

                    }
                }

                orders = Console.ReadLine();
            }

            var currentBill = customer.Bill;
            var totalBill = 0.0M;

            foreach (var student in shoppingList.OrderBy(s => s.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var order in student.Value)
                {
                    foreach (var item in shop)
                    {
                        if (order.Key.Equals(item.Key))
                        {
                            currentBill = item.Value * order.Value;
                        }
                    }

                    Console.WriteLine($"-- {order.Key} - {order.Value}");
                    Console.WriteLine($"Bill: {currentBill:f2}");
                }

                totalBill += currentBill;
            }

            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
