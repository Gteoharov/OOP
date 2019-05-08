using System;

namespace HotelReservation
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var hotelPriceCalculator = PriceCalculator.CalculatePrice(75, 5, Season.Summer, DiscountType.None);
            Console.WriteLine(hotelPriceCalculator);
        }
    }
}
