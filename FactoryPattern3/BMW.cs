using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern3
{
    class BMW : ISupplier
    {
        public void CarSupplier()
        {
            Console.WriteLine("BMW Supplier");
        }
    }
}
