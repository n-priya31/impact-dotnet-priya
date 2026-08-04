using Pattern.Models;

namespace Pattern.FactoryMethod
{
    public class CarFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Car();
        }
    }
}