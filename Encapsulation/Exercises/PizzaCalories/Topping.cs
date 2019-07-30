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
            this.ToppingType = toppingType;
            this.Weight = weight;
        }

        public string ToppingType
        {
            get => this.toppingType;

            private set
            {
                if (!this.validToppingTypes.ContainsKey(value.ToLower()))
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
            this.validToppingTypes.Add("meat", 1.2);
            this.validToppingTypes.Add("veggies", 0.8);
            this.validToppingTypes.Add("cheese", 1.1);
            this.validToppingTypes.Add("sauce", 0.9);
        }

        public double CalculateCalories()
        {
            return BaseToppingCalories * weight * validToppingTypes[this.ToppingType.ToLower()];
        }
    }
}
