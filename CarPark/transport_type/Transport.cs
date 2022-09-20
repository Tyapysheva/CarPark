using System.Xml.Serialization;
using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    [Serializable]

    public abstract class Transport
    {
        protected Engine engine;
        protected Chassis chassis;
        protected Transmission transmission;
        public Transport()
        {

        }

        public Transport(Engine engine, Chassis chassis, Transmission transmission)
        {
            Engine = engine;
            this.chassis = chassis;
            this.transmission = transmission;
        }

        public Engine Engine
        {
            get => engine;
            set
            {
                CompareUtil.checkFieldNotNull("Engine", value);
                engine = value;
            }
        }

        public Chassis Chassis
        {
            get => chassis;
            set
            {
                CompareUtil.checkFieldNotNull("Chassis", value);
                chassis = value;
            }
        }
        public Transmission Transmission
        {
            get => transmission;
            set
            {
                CompareUtil.checkFieldNotNull("Transmission", value);
                transmission = value;
            }
        }
    }
}

