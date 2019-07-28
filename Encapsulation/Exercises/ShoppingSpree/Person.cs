namespace ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Name cannot be empty string.");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative number.");
                }
                this.money = value;
            }
        }

        public List<Product> Bag
        {
            get { return this.bag; }
        }

        public string BuyProduct(Product product)
        {
            if (this.Money >= product.Cost)
            {
                this.Money -= product.Cost;
                this.Bag.Add(product);
                return $"{this.Name} bought {product.Name}";
            }

            return $"{this.Name} can't afford {product.Name}";
        }
    }
}
