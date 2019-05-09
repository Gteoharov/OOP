namespace HotelReservation
{
    using System;

    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private DiscountType discount;

        public decimal PricePerDay
        {
            get
            {
                return this.pricePerDay;
            }
            set
            {
                this.pricePerDay = value;
            }
        }

        public int NumberOfDays
        {
            get
            {
                return this.numberOfDays;
            }
            set
            {
                this.numberOfDays = value;
            }
        }

        public Season Season
        {
            get
            {
                return this.season;
            }
            set
            {
                this.season = value;
            }
        }

        public DiscountType Discount
        {
            get
            {
                return this.discount;
            }
            set
            {
                this.discount = value;
            }
        }

        public decimal CalculatePrice(decimal pricePerDay, int numberOfDays, Season season, DiscountType discount)
        {
            int multiplier = (int)season;
            decimal discountPrice = (decimal)discount / 100;

            decimal priceBeforeDiscount = numberOfDays * pricePerDay * multiplier;
            decimal discountedAmount = priceBeforeDiscount * discountPrice;
            decimal finalPrice = priceBeforeDiscount - discountedAmount;

            return finalPrice;
        }
    }
}
