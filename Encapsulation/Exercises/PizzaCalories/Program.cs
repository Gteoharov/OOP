namespace PizzaCalories
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] doughArgs = Console.ReadLine().Split(' ');

            string doughFlourType = doughArgs[1];
            string doughBakingTechnique = doughArgs[2];

            double weight = double.Parse(doughArgs[3]);

            try
            {
                Dough dough = new Dough(doughFlourType, doughBakingTechnique, weight);
                Console.WriteLine(dough.CalculateCalories().ToString("f2"));

                string[] toppingArgs = Console.ReadLine().Split(' ');

                string toppingType = toppingArgs[1];
                double weightTopping = double.Parse(toppingArgs[2]);

                Topping topping = new Topping(toppingType, weightTopping);
                Console.WriteLine(topping.CalculateCalories().ToString("f2"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
