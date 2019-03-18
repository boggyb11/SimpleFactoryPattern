using System;

namespace FactoryPattern3
{
    class Program
    {
        static void Main(string[] args)
        {
            ISupplier car = CarFactory.GetCar(1);
            car.CarSupplier();
            car = CarFactory.GetCar(2);
            car.CarSupplier();
            Console.ReadLine();
        }
    }
}
