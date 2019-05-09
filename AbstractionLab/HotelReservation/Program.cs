namespace HotelReservation
{
    using System;
    using System.Linq;

    class MainClass
    {
        public static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split().ToArray();

            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);

            Season season = new Season();
            DiscountType discount = new DiscountType();

            string seasonType = input[2];
            switch (seasonType)
            {
                case "Summer":
                    season = (Season)4;
                    break;
                case "Winter":
                    season = (Season)3;
                    break;
                case "Autumn":
                    season = (Season)1;
                    break;
                case "Spring":
                    season = (Season)2;
                    break;
                default:
                    break;
            }
            if (input.Length == 4)
            {
                string discountType = input[3];
                switch (discountType)
                {
                    case "VIP":
                        discount = (DiscountType)20;
                        break;
                    case "SecondVisit":
                        discount = (DiscountType)10;
                        break;
                    default:
                        break;
                }
            }
            PriceCalculator calculator = new PriceCalculator();
            decimal finalPrice = calculator.CalculatePrice(pricePerDay, numberOfDays, season, discount);
            Console.WriteLine($"{finalPrice:F2}")   ;
        }
    }
}
