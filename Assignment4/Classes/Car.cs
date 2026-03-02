using Assignment4.Abstraction;

namespace Assignment4.Classes
{
    public class Car : VehicleBase
    {
        public override void Stop()
        {
            Log($"{Brand} car stopped");
        }

        public override double CalculateFuelConsumption(double distance)
        {
            double CFConsumption = base.CalculateFuelConsumption(distance);
            return CFConsumption * 1.1;
        }

        public Car(string brand) : base(brand) { }
    }
}
