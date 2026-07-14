using System;

class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Console.WriteLine("Vehicle Constructor");

        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Make : {Make}");
        Console.WriteLine($"Model : {Model}");
        Console.WriteLine($"Year : {Year}");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        Console.WriteLine("Car Constructor");

        NumberOfDoors = numberOfDoors;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors : {NumberOfDoors}");
    }
}

class Bike : Vehicle
{
    public bool HasSidecar { get; set; }

    public Bike(string make, string model, int year, bool hasSidecar)
        : base(make, model, year)
    {
        Console.WriteLine("Bike Constructor");

        HasSidecar = hasSidecar;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Has Sidecar : {HasSidecar}");
    }
}

class ElectricCar : Car
{
    public int BatteryCapacity { get; set; }

    public ElectricCar(string make, string model, int year, int numberOfDoors, int batteryCapacity)
        : base(make, model, year, numberOfDoors)
    {
        Console.WriteLine("ElectricCar Constructor");

        BatteryCapacity = batteryCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Battery Capacity : {BatteryCapacity} kWh");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine(" Car ");
        Car car = new Car("Toyota", "Corolla", 2023, 4);
        car.DisplayInfo();

        Console.WriteLine(" Bike ");
        Bike bike = new Bike("Honda", "Shine", 2022, false);
        bike.DisplayInfo();

        Console.WriteLine(" Electric Car ");
        ElectricCar tesla = new ElectricCar("Tesla", "Model Y", 2025, 4, 75);
        tesla.DisplayInfo();
    }
}