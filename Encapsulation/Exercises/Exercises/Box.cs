namespace Exercises
{
    using System;

    public class Box
    {
        private double length;
        private double width;
        private double height;


        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Width = width;
            this.Height = height;
        }

        public double Lenght
        {
            get
            {
                return this.length;
            }
            private set
            {
                this.ValidateDigits(value);
                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                this.ValidateDigits(value);
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                this.ValidateDigits(value);
                this.height = value;
            }
        }

        private void ValidateDigits(double digit)
        {
            if (digit <= 0)
            {
                throw new ArgumentException($"{digit} cannot be zero or negative.");
            }
        }

        public double SurfaceArea()
        {
            return (2 * Lenght * Width) + (2 * Lenght * Height) + (2 * Height * Width);
        }

        public double LateralSurfaceArea()
        {
            return (2 * Lenght * Height) + (2 * Height * Width);
        }

        public double Volume()
        {
            return Lenght * Height * Width;
        }
    }
}
