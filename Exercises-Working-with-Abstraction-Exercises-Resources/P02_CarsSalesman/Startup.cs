using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P02_CarsSalesman
{
    public class Startup
    {
        static void Main(string[] args)
        {
            CarFactorty carFactory = new CarFactorty();
            EngineFactory engineFactory = new EngineFactory();

            CarSalesman carSalesman = new CarSalesman(carFactory, engineFactory);

            int engineCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < engineCount; i++)
            {
                string[] parameteres = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carSalesman.AddEngine(parameteres);

            }
            int carCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                carSalesman.AddCar(parameters);
            }

            foreach (var car in carSalesman.Cars)
            {
                Console.WriteLine(car);
            }
        }
    }

}
