using Assignment4.Interfaces;

namespace Assignment4.Abstraction
{
    public abstract class VehicleBase : IVehicle
    {
        //Brand Property
        public string Brand { get; set; }
        public virtual double CalculateFuelConsumption(double distance)
        {
            return distance = 1;
        }

        public virtual void Start()
        {
            Log($"{Brand} is starting");
        }

        public abstract void Stop();

        //Log Message
        public void Log(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        //Constructor
        public VehicleBase(string brand)
        {
            Brand = brand;
        }
    }
}
