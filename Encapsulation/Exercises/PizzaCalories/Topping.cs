namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Topping
    {
        private const double BaseToppingCalories = 2;

        private string toppingType;
        private double weight;
        private Dictionary<string, double> validToppingTypes;

        public Topping(string toppingType, double weight)
        {
            this.validToppingTypes = new Dictionary<string, double>();
            this.seedToppingType();
            this.toppingType = toppingType;
            this.weight = weight;
        }

        public string ToppingType
        {
            get => this.toppingType;

            private set
            {
                if (!this.validToppingTypes.ContainsKey(value))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        public double Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private void seedToppingType()
        {
            this.validToppingTypes.Add("Meat", 1.2);
            this.validToppingTypes.Add("Veggies", 0.8);
            this.validToppingTypes.Add("Cheese", 1.1);
            this.validToppingTypes.Add("Sauce", 0.9);
        }

        public double CalculateCalories()
        {
            return BaseToppingCalories * weight * validToppingTypes[this.ToppingType];
        }
    }
}
