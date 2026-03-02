namespace Assignment4.Interfaces
{
    internal interface IVehicle
    {
        void Start();

        void Stop();

        double CalculateFuelConsumption(double distance);
    }
}
