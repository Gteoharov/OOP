namespace PizzaCalories
{
    using System;
    using System.Collections.Generic;

    public class Dough
    {
        private const double BaseDoughCalories = 2;
        private string flourType;
        private string beckingTechnique;
        private double weight;
        private Dictionary<string, double> validFlourTypes;
        private Dictionary<string, double> validBackingTechniques;

        public Dough(string flourType, string beckingTechnique, double weight)
        {
            this.validFlourTypes = new Dictionary<string, double>();
            this.validBackingTechniques = new Dictionary<string, double>();
            this.SeedFlourTypes();
            this.SeedBackingTechniques();
            this.FlourType = flourType;
            this.BeckingTechnique = beckingTechnique;
            this.Weight = weight;
        }

        public string FlourType
        {
            get
            {
                return this.flourType;
            }
            private set
            {
                if (!validFlourTypes.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BeckingTechnique
        {
            get
            {
                return this.beckingTechnique;
            }
            private set
            {
                if (!validBackingTechniques.ContainsKey(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                this.beckingTechnique = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1...200].");
                }
                this.weight = value;
            }
        }

        public double CalculateCalories()
        {
            return BaseDoughCalories * this.Weight * validBackingTechniques[this.BeckingTechnique] * validFlourTypes[this.FlourType];
        }

        private void SeedFlourTypes()
        {
            this.validFlourTypes.Add("White", 1.5);
            this.validFlourTypes.Add("Wholegrain", 1.0);
        }

        private void SeedBackingTechniques()
        {
            this.validBackingTechniques.Add("Chrispy", 0.9);
            this.validBackingTechniques.Add("Chewy", 1.1);
            this.validBackingTechniques.Add("Homemade", 1.0);
        }
    }
}
