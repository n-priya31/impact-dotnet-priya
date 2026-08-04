//using Pattern.Models;
//using Pattern.SimpleFactory;

//IVehicle vehicle = VehicleFactory.CreateVehicle("car");
//vehicle.Drive();

//vehicle = VehicleFactory.CreateVehicle("bike");
//vehicle.Drive();

//vehicle = VehicleFactory.CreateVehicle("truck");
//vehicle.Drive();

using Pattern.FactoryMethod;
using Pattern.Models;

VehicleFactory factory;

factory = new CarFactory();
IVehicle car = factory.CreateVehicle();
car.Drive();

factory = new BikeFactory();
IVehicle bike = factory.CreateVehicle();
bike.Drive();

factory = new TruckFactory();
IVehicle truck = factory.CreateVehicle();
truck.Drive();