namespace PointInRectangle
{
    using System;

    public class Rectangle
    {
        public Point TopLeft { get; set; }

        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public bool Contains(Point point)
        {
            bool isHorizontal = this.TopLeft.X <= point.X && this.BottomRight.X >= point.X;

            bool isInVertical = this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;

            bool isInRectangle = isHorizontal && isInVertical;

            return isInRectangle;
        }
    }
}
