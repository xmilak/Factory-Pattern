using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Bike : IVehicle
    {
        public Bike()
        {
            Console.WriteLine("Confirmed order");
        }

        public void Build()
        {
            Console.WriteLine("Getting tires for bike");
        }
    }
}
