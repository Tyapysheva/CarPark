using System.Xml.Linq;
using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{


    class Truck : Transport
    {
        public Truck(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            checkEngine(engine);
            checkChasis(chassis);
            checkTransmission(transmission);
        }

        private void checkEngine(Engine engine)
        {
            CompareUtil.checkFieldWithSign("Truck Engine power", engine.Power, CompareSign.GREATER, 199);
            CompareUtil.checkFieldWithSign("Truck Engine power", engine.Power, CompareSign.LESS, 751);
            CompareUtil.checkFieldWithSign("Truck Engine capacity", engine.Power, CompareSign.GREATER, 6);
            CompareUtil.checkFieldWithSign("Truck Engine capacity", engine.Capacity, CompareSign.LESS, 21);
            CompareUtil.checkTypeEngine("Truck Engine type", engine.TypeEngine, TypeEngine.TRUCK_ENGINE);
            this.engine = engine;
        }
        private void checkTransmission(Transmission transmission)
        {
            CompareUtil.checkTypeTransmission("Truck Transmission type", typeof(Truck), transmission.TypeTransmission);
            CompareUtil.checkFieldWithSign("Truck Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.GREATER, 4);
            CompareUtil.checkFieldWithSign("Truck Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.LESS, 17);
          
            this.transmission = transmission;
        }

        private void checkChasis(Chassis chassis)
        {
            CompareUtil.checkFieldWithSign("Truck Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.GREATER, 25000);
            CompareUtil.checkFieldWithSign("Truck Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.LESS, 70000);
            CompareUtil.checkFieldWithSign("Truck Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.LESS, 32);
            this.chassis = chassis;
        }

        public override string? ToString()
        {

            return "\nTruck: \nEngine: \nType = " + engine.TypeEngine +
                "; Capacity = " + engine.Capacity + "; Power = " + engine.Power + "; Serial number = " + engine.SerialNumber +
                "\nChassis: \nNumber = " + chassis.Number +
                "; Number Of Wheels = " + chassis.NumberOfWheels + "; Permissible Load = " + chassis.PermissibleLoad +
                "\nTransmission: \nType = " + transmission.TypeTransmission +
                "; Number Of Gears = " + transmission.NumberOfGears + "; Manufacturer = " + transmission.Manufacturer;
        }
    }
}
