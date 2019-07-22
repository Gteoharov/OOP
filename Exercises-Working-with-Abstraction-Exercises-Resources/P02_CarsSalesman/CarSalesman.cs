using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman
{
    public class CarSalesman
    {
        private List<Engine> engines;
        private CarFactorty carFactorty;
        private EngineFactory engineFactory;

        public CarSalesman(CarFactorty carFactory, EngineFactory engineFactory)
        {
            this.Cars = new List<Car>();
            this.engines = new List<Engine>();
            this.carFactorty = carFactory;
            this.engineFactory = engineFactory;
        }

        public List<Car> Cars { get; private set; }

        public void AddEngine(string[] parameters)
        {
            Engine engie = engineFactory.Create(parameters);
            engines.Add(engie);
        }

        public void AddCar(string[] parameters)
        {
            Car car = carFactorty.Create(parameters, engines);
            Cars.Add(car);
        }
    }
}
