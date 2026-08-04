using Pattern.Models;

namespace Pattern.FactoryMethod
{
    public class TruckFactory : VehicleFactory
    {
        public override IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }
}