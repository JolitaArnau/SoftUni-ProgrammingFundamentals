namespace Pr07AndreyAndBilliard
{
    using System.Collections.Generic;

    class Customer
    {
        public Dictionary<string, Dictionary<string,int>> ShoppingList { get; set; }

        public decimal Bill { get; set; }
    }
}
