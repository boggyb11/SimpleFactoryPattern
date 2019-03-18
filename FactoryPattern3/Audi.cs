using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern3
{
    class Audi : ISupplier
    {
        public void CarSupplier()
        {
            Console.WriteLine("Audi Supplier");
        }
    }
}
