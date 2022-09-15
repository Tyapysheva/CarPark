using System.Runtime.Intrinsics.X86;
using CarPark.transport_parts;
using CarPark.transport_type;

namespace Carpark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(400F, 20.0F, TypeEngine.TRUCK_ENGINE, 123);
            Chassis chassis = new Chassis(16, 43, 55000);
            Transmission transmission = new Transmission(TypeTransmission.MANUAL, 7, "manufacture");
            Truck truck = new Truck(engine,chassis,transmission);

            Engine engine1 = new Engine(230F, 6.0F, TypeEngine.BUS_ENGINE, 125);
            Chassis chassis1 = new Chassis(8, 46, 11000);
            Transmission transmission1 = new Transmission(TypeTransmission.AUTOMATIC, 4, "manufacture");
            Bus bus = new Bus(engine1, chassis1, transmission1);

            Engine engine2 = new Engine(50F, 0.04F, TypeEngine.SCOOTER_ENGINE, 127);
            Chassis chassis2 = new Chassis(2, 23, 250);
            Transmission transmission2 = new Transmission(TypeTransmission.CONTINUOSLY_VARIABLE, 2, "manufacture");
            Scooter scooter = new Scooter(engine2, chassis2, transmission2);

            Engine engine3 = new Engine(200F, 4F, TypeEngine.CAR_ENGINE, 127);
            Chassis chassis3 = new Chassis(4, 30, 6000);
            Transmission transmission3 = new Transmission(TypeTransmission.CONTINUOSLY_VARIABLE, 15, "manufacture");
            PassengerCar passengerCar = new PassengerCar(engine3, chassis3, transmission3);

            Console.WriteLine(truck);
            Console.WriteLine(bus);
            Console.WriteLine(scooter);
            Console.WriteLine(passengerCar);
        }
    }
}

