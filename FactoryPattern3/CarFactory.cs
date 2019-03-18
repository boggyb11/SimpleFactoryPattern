using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern3
{
    class CarFactory
    {
        public static ISupplier GetCar(int key)
        {
            switch (key)
            {
                case 1:
                    return new Audi();
                case 2:
                    return new BMW();
                default:
                    return new Audi();
            }
        }
    }
}
