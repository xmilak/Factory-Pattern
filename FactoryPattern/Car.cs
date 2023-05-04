using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Confirmed order");
        }

        public void Build()
        {
            Console.WriteLine("Car Automation Underway");
        }
    }
}
