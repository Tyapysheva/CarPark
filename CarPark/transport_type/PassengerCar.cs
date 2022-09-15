using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    class PassengerCar : Transport
    {
        public PassengerCar(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            checkEngine(engine);
        }

        private void checkEngine(Engine engine)
        {
            CompareUtil.checkFieldWithSign("Passenger Car Engine power", engine.Power, CompareSign.GREATER, 99);
            CompareUtil.checkFieldWithSign("Passenger Car Engine power", engine.Power, CompareSign.LESS, 260);
            CompareUtil.checkFieldWithSign("Passenger Car Engine capacity", engine.Power, CompareSign.GREATER, 1);
            CompareUtil.checkFieldWithSign("Passenger Car Engine capacity", engine.Capacity, CompareSign.LESS, 6);
            CompareUtil.checkTypeEngine("Passenger Car Engine type", engine.TypeEngine, TypeEngine.CAR_ENGINE);
            this.engine = engine;

        }
        private void checkTransmission(Transmission transmission)
        {
            CompareUtil.checkTypeTransmission("Passenger Car Transmission type", typeof(PassengerCar), transmission.TypeTransmission);
            CompareUtil.checkFieldWithSign("Passenger Car Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.GREATER, 3);
            CompareUtil.checkFieldWithSign("Passenger Car Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.LESS, 18);

            this.transmission = transmission;
        }

        private void checkChasis(Chassis chassis)
        {
            CompareUtil.checkFieldWithSign("Passenger Car Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.GREATER, 5000);
            CompareUtil.checkFieldWithSign("Passenger Car Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.LESS, 15000);
            CompareUtil.checkFieldWithSign("Passenger Car Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.GREATER, 3);
            CompareUtil.checkFieldWithSign("Passenger Car Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.LESS, 5);
            this.chassis = chassis;
        }
        public override string? ToString()
        {
            return "\nPassenger Car: \nEngine: \nType = " + engine.TypeEngine +
                "; Capacity = " + engine.Capacity + "; Power = " + engine.Power + "; Serial number = " + engine.SerialNumber +
                "\nChassis: \nNumber = " + chassis.Number +
                "; Number Of Wheels = " + chassis.NumberOfWheels + "; Permissible Load = " + chassis.PermissibleLoad +
                "\nTransmission: \nType = " + transmission.TypeTransmission +
                "; Number Of Gears = " + transmission.NumberOfGears + "; Manufacturer = " + transmission.Manufacturer;
        }
    }
}

