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
                if (!validFlourTypes.ContainsKey(value.ToLower()))
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
                return beckingTechnique;
            }
            private set
            {
                if (!validBackingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid becking of becking.");
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
            return BaseDoughCalories * this.Weight * validBackingTechniques[this.BeckingTechnique.ToLower
                ()] * validFlourTypes[this.FlourType.ToLower()];
        }

        private void SeedFlourTypes()
        {
            this.validFlourTypes.Add("white", 1.5);
            this.validFlourTypes.Add("wholegrain", 1.0);
        }

        private void SeedBackingTechniques()
        {
            this.validBackingTechniques.Add("crispy", 0.9);
            this.validBackingTechniques.Add("chewy", 1.1);
            this.validBackingTechniques.Add("homemade", 1.0);
        }
    }
}
