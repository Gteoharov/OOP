namespace Exercises
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {


            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Box box = new Box(lenght, width, height);

            Console.WriteLine($"Surface Area - {box.SurfaceArea()}");
            Console.WriteLine($"Lateral Surface Area – {box.LateralSurfaceArea()}");
            Console.WriteLine($"Volume - {box.Volume()}");
        }
    }
}
