using System;

public abstract class Vehicle
{
    public string Brand { get; set; }

    public Vehicle(string brand)
    {
        Brand = brand;
    }

    public void ShowBrand()
    {
        Console.WriteLine($"Brand: {Brand}");
    }

    public abstract void Drive();
}