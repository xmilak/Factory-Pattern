using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Train : IVehicle
    {
        public Train()
        {
            Console.WriteLine("Confirmed order");
        }

        public void Build()
        {
            Console.WriteLine("Extending railways for train");
        }
    }
}
