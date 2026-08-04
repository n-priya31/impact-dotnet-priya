using Pattern.Models;

namespace Pattern.FactoryMethod
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}