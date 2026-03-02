using Assignment4.Classes;

Car car = new Car("Toyota");
Motorcycle bike = new Motorcycle("Honda");

car.Start();
car.Stop();
Console.WriteLine(car.CalculateFuelConsumption(80));

bike.Start();
bike.Stop();
Console.WriteLine(bike.CalculateFuelConsumption(60));