
namespace P01_RawData
{
    using System;
    using System.Collections.Generic;

    public class CarCatalog
    {
        private List<Car> cars;

        public CarCatalog()
        {
            this.cars = new List<Car>();
        }

        public void Add(string[] parameters)
        {
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];

            Engine engine = new Engine(engineSpeed, enginePower);
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Tire[] tires = new Tire[4];

            int indexOfTire = 0;
            for (int indexTire = 5; indexTire <= 12; indexTire++)
            {
                double tirePressure = double.Parse(parameters[indexTire]);
                int tireAge = int.Parse(parameters[indexTire]);

                Tire tire = new Tire(tirePressure, tireAge);
                tires[indexOfTire] = tire;
                indexOfTire++;
            }

            Car car = new Car(model, engine, cargo, tires);

            cars.Add(car);
        }
    }
}
