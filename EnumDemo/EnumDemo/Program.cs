using System;

namespace EnumDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            var coffee = new Coffee();
            int size = (int)CoffeeSize.Small;
            int coffeSize = (int)coffee.Size;
            CoffeeSize largeCoffeSize = (CoffeeSize)200;

            Console.WriteLine(coffee.Size);
            Console.WriteLine(size);
            Console.WriteLine(coffeSize);
            coffee.Size = CoffeeSize.Medium;
            Console.WriteLine(coffee.Size);
            Console.WriteLine(largeCoffeSize + "\n");

            var color = Color.Green;


            if (color == Color.Green)
            {
                Console.WriteLine("Aleluq");
            }

            switch (color)
            {
                case Color.White:
                    break;
                case Color.Blacl:
                    break;
                case Color.Red:
                    break;
                case Color.Blue:
                    break;
                case Color.Green:
                    Console.WriteLine("Green");
                    break;
                default:
                    break;
            }
        }
    }
}
