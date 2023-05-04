namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of vehicle do you want?(Bike, car, train, plane)");
            string vehicleRequest = Console.ReadLine();

            IVehicle vehicle = VehDeptFactory.GetVehDept(vehicleRequest);
            //Notes from lecture. This is building a new object in vehicle factory
            //IVehicle vehicle = new VehDeptFactory();

            Console.WriteLine();
            vehicle.Build();
        }
    }
}
