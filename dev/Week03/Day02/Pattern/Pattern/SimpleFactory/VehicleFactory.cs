using Pattern.Models;

namespace Pattern.SimpleFactory
{
    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string type)
        {
            switch (type.ToLower())
            {
                case "car":
                    return new Car();

                case "bike":
                    return new Bike();

                case "truck":
                    return new Truck();

                default:
                    throw new ArgumentException("Invalid Vehicle Type");
            }
        }
    }
}