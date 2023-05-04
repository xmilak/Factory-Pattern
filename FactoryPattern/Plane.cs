using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Plane : IVehicle
    {
        public Plane()
        {
            Console.WriteLine("Confirmed order");
        }

        public void Build()
        {
            Console.WriteLine("Prepping plane for flying");
        }
    }
}
