using Assignment4.Abstraction;

namespace Assignment4.Classes
{
    public class Motorcycle : VehicleBase
    {
        public override void Stop()
        {
            Log($"{Brand} motorcycle stopped");
        }

        public Motorcycle(string brand) : base(brand){}
    }
}
