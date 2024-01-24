using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using System.Configuration;

interface IVehicle
{
    void Drive();
}
class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Driving a car...");
}
class Motorcycle : IVehicle
{
    public void Drive() => Console.WriteLine("Riding a motorcycle...");
}
interface IVehicleFactory
{
    public abstract IVehicle CreateVehicle();
}
class CarFactory : IVehicleFactory
{
    public IVehicle CreateVehicle() => new Car();
}
class MotorcycleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle() => new Motorcycle();
}
class Program
{
    static void Main()
    {
        IVehicle vehicle = Initialize().CreateVehicle();
        vehicle.Drive(); // Output depends on the configuration
    }

    static IVehicleFactory Initialize()
    {
        AppSettingsReader reader = new AppSettingsReader();

        string vehicleType = (string)reader.GetValue("VehicleType", typeof(string));
        IVehicleFactory vehicleFactory;
        if (vehicleType == "Car") vehicleFactory = new CarFactory();
        else if (vehicleType == "Motorcycle") vehicleFactory = new MotorcycleFactory();
        else throw new NotSupportedException($"Unknown vehicle type: {vehicleType}");
        return vehicleFactory;
    }
}