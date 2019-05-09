using System;

namespace AbstractionLab
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            for (int starCount = 1; starCount <= size; starCount++)
            {
                PrintRow(size, starCount);
            }
            for (int starCount = size - 1; starCount >= 1; starCount--)
            {
                PrintRow(size, starCount);
            }

        }

        public static void PrintRow(int figureSize, int startCount)
        {
            for (int i = 0; i < figureSize - startCount; i++)
            {
                Console.Write(" ");


            }
            for (int col = 1; col < startCount; col++)
            {
                Console.Write("* ");

            }
            Console.WriteLine("*");
        }
    }
}
