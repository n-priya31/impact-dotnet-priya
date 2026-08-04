using System;

public class Car : Vehicle, IVehicle
{
    public Car(string brand) : base(brand)
    {
    }

    public void Start()
    {
        Console.WriteLine("Car Started");
    }

    public override void Drive()
    {
        Console.WriteLine("Car is Driving");
    }
}