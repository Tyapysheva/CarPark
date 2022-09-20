using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]
    public class Scooter : Transport
    {
        public Scooter()
        {
            
        }
        public Scooter(Engine engine, Chassis chassis, Transmission transmission) : base(engine, chassis, transmission)
        {
            checkEngine(engine);
        }

        private void checkEngine(Engine engine)
        {
            CompareUtil.checkFieldWithSign("Scooter Engine power", engine.Power, CompareSign.GREATER, 45);
            CompareUtil.checkFieldWithSign("Scooter Engine power", engine.Power, CompareSign.LESS, 65);
            CompareUtil.checkFieldWithSign("Scooter Engine capacity", engine.Power, CompareSign.GREATER, 0.005);
            CompareUtil.checkFieldWithSign("Scooter Engine capacity", engine.Capacity, CompareSign.LESS, 1);
            CompareUtil.checkTypeEngine("Scooter Engine type", engine.TypeEngine, TypeEngine.SCOOTER_ENGINE);
            this.engine = engine;

        }
        private void checkTransmission(Transmission transmission)
        {
            CompareUtil.checkTypeTransmission("Scooter Transmission type", typeof(Scooter), transmission.TypeTransmission);
            CompareUtil.checkFieldWithSign("Scooter Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.GREATER, 1);
            CompareUtil.checkFieldWithSign("Scooter Transmission Number Of Gears", transmission.NumberOfGears, CompareSign.LESS, 4);

            this.transmission = transmission;
        }

        private void checkChasis(Chassis chassis)
        {
            CompareUtil.checkFieldWithSign("Scooter Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.GREATER, 59);
            CompareUtil.checkFieldWithSign("Scooter Chassis Permissible Load", chassis.PermissibleLoad, CompareSign.LESS, 359);
            CompareUtil.checkFieldWithSign("Scooter Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.GREATER, 1);
            CompareUtil.checkFieldWithSign("Scooter Chassis Number Of Wheels", chassis.NumberOfWheels, CompareSign.LESS, 3);
            this.chassis = chassis;
        }

        public override string? ToString()
        {
            return "\nScooter:" + Engine + Chassis + Transmission;
        }
    }

}


