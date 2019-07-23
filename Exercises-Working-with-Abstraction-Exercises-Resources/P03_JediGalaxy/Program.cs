using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = Matrix.Create(dimestions);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoScore = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilScore = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int xEvil = evilScore[0];
                int yEvil = evilScore[1];

                while (xEvil >= 0 && yEvil >= 0)
                {
                    if (xEvil >= 0 && xEvil < matrix.GetLength(0) && yEvil >= 0 && yEvil < matrix.GetLength(1))
                    {
                        matrix[xEvil, yEvil] = 0;
                    }
                    xEvil--;
                    yEvil--;
                }

                int xIvo = ivoScore[0];
                int yIvo = ivoScore[1];

                while (xIvo >= 0 && yIvo < matrix.GetLength(1))
                {
                    if (xIvo >= 0 && xIvo < matrix.GetLength(0) && yIvo >= 0 && yIvo < matrix.GetLength(1))
                    {
                        sum += matrix[xIvo, yIvo];
                    }

                    yIvo++;
                    xIvo--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }
    }
}
