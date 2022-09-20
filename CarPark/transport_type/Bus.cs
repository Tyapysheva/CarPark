using System.Xml.Serialization;
using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]
    
    public class Bus : Transport
    {
        public Bus()
        {

        }
        public Bus(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            checkEngine(engine);
        }

        private void checkEngine(Engine engine)
        {
            CompareUtil.checkFieldWithSign("Bus Engine power", engine.Power, CompareSign.GREATER, 210);
            CompareUtil.checkFieldWithSign("Bus Engine power", engine.Power, CompareSign.LESS, 285);
            CompareUtil.checkFieldWithSign("Bus Engine capacity", engine.Capacity, CompareSign.GREATER, 3.5);
            CompareUtil.checkFieldWithSign("Bus Engine capacity", engine.Capacity, CompareSign.LESS, 8.5);
            CompareUtil.checkTypeEngine("Bus Engine type", engine.TypeEngine, TypeEngine.BUS_ENGINE);
            this.engine = engine;

        }
        private void checkTransmission(Transmission transmission)
        {
            CompareUtil.checkTypeTransmission("Bus Transmission type", typeof(Bus), transmission.TypeTransmission);
            CompareUtil.checkFieldWithSign("Bus Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.GREATER, 4);
            CompareUtil.checkFieldWithSign("Bus Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.LESS, 11);

            this.transmission = transmission;
        }

        private void checkChasis(Chassis chassis)
        {
            CompareUtil.checkFieldWithSign("Bus Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.GREATER, 10000);
            CompareUtil.checkFieldWithSign("Bus Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.LESS, 25000);
            CompareUtil.checkFieldWithSign("Bus Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.GREATER, 3);
            CompareUtil.checkFieldWithSign("Bus Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.LESS, 20);
            this.chassis = chassis;
        }
        public override string? ToString()
        {
            return "\nBus:" + Engine + Chassis + Transmission;
        }

    }


}

