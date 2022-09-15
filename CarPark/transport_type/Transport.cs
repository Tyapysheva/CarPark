using CarPark.transport_parts;
using CarPark.utility;

namespace CarPark.transport_type
{
    class Transport
    {
        protected Engine engine;
        protected Chassis chassis;
        protected Transmission transmission;

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

    }
}

