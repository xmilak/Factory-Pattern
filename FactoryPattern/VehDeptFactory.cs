using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehDeptFactory 
    {
        public static IVehicle GetVehDept(string vehicletype)
        {
            switch (vehicletype.ToLower()) 
            {
                case "bike":
                    return new Bike();
                case "car":
                    return new Car();
                case "train":
                    return new Train();
                case "plane":
                    return new Plane();
                default:
                    return new Plane();
               

            }

        }
    }
}
