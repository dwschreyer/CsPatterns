using CreationalPatterns.AbstractFactory;
using System;

namespace CsPatternsCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C# Patterns from the Gang of Four!");
            Console.WriteLine(new string('=', 50));

            //Creational Pattern Abstract Factory
            Console.WriteLine(nameof(CreationalPatterns.AbstractFactoryUsage));
            var car = CreationalPatterns.AbstractFactoryUsage.GetStartedVehicle<Car>();
            var truck = CreationalPatterns.AbstractFactoryUsage.GetStartedVehicle<Truck>();
            Console.WriteLine($"PassengerCapacity:{(car as Car).PassengerCapacity}");
            Console.WriteLine($"LoadCapacity:{(truck as Truck).LoadCapacity}");
            car.Stop();
            truck.Stop();
            Console.WriteLine(new string('=', 50));

            //Creational Patterns Builder
            Console.WriteLine(nameof(CreationalPatterns.BuilderUsage));
            var house = CreationalPatterns.BuilderUsage.BuildAHouse();
            Console.WriteLine($"GarageCount:{house.GarageCount}");
            Console.WriteLine(new string('=', 50));

            //Creational Patterns Factory Method
            Console.WriteLine(nameof(CreationalPatterns.FactoryMethod));
            var bolt = CreationalPatterns.FactoryMethodUsage.GetFastener();
            Console.WriteLine($"Bolt Code:{bolt.GetCode()}");
            Console.WriteLine(new string('=', 50));

            //Creational Patterns Prototype
            Console.WriteLine(nameof(CreationalPatterns.Prototype));
            var dogs = CreationalPatterns.PrototypeUsage.CreateDogsFromDog();
            foreach (var dog in dogs)
            {
                Console.WriteLine($"Dog :{dog.Name}");
            }
            Console.WriteLine(new string('=', 50));

            //Creational Patterns Singleton
            Console.WriteLine(nameof(CreationalPatterns.Singleton));
            var createdAt = CreationalPatterns.SingltonUsage.GetCreatedAt();
            Console.WriteLine($"Created At :{createdAt}");
            Console.WriteLine(new string('=', 50));

            //Creational Patterns Modern Singleton
            Console.WriteLine("Modern " + nameof(CreationalPatterns.Singleton));
            var modernCreatedAt = CreationalPatterns.SingltonUsage.GetModernCreatedAt();
            Console.WriteLine($"Modern Created At :{modernCreatedAt}");
            Console.WriteLine(new string('=', 50));


            //Structural Patters Facade
            Console.WriteLine(nameof(StructuralPatterns.FacadeUsage));
            var permutations = StructuralPatterns.FacadeUsage.Use();
            foreach (var item in permutations)
            {
                Console.WriteLine($"Permutation :{item}");
            }
            Console.WriteLine(new string('=', 50));

        }
    }
}
