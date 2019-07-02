using CreationalPatterns.AbstractFactory;
using System;

namespace CreationalPatterns
{
    public static class AbstractFactoryUsage
    {
        public static IVehicle GetStartedVehicle<TVehicle>()
            where TVehicle : class, IVehicle, new()
        {
            IVehicleFactory factory;
            switch (new TVehicle())
            {
                case Car c:
                    factory = new CarFactory();
                    break;
                case Truck t:
                    factory = new TruckFactory();
                    break;
                default:
                    throw new NotImplementedException();
            }

            var result = factory.CreateVehicle();
            result.Start();
            return result; //Return IVehicle and not TVehicle; TVehicle would be the concrete type, we want the abstract type (IVehicle).
        }
    }
}
