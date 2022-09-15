using CarPark.utility;

namespace CarPark.transport_parts
{
    class Engine
    {
        private float power;
        private float capacity;
        private TypeEngine typeEngine;
        private long serialNumber;

        public Engine(float power, float capacity, TypeEngine typeEngine, long serialNumber)
        {
            Power = power;
            Capacity = capacity;
            TypeEngine = typeEngine;
            SerialNumber = serialNumber;
        }

        public float Power
        {
            get => power;
            set
            {
                CompareUtil.checkFieldWithSign("Power", value, CompareSign.GREATER, 0);
                power = value;
            }
        }
        public float Capacity
        {
            get => capacity; 
            set
            {
                CompareUtil.checkFieldWithSign("Capacity", value, CompareSign.GREATER, 0);
                capacity = value;
            }
        }
        public TypeEngine TypeEngine
        {
            get => typeEngine; 
            set
            {
                CompareUtil.checkFieldNotNull("Capacity", value);
                typeEngine = value;
            }
        }
        public long SerialNumber { get => serialNumber; 
            set
            {
                CompareUtil.checkFieldWithSign("Serial Number", value, CompareSign.GREATER, 0);
                serialNumber = value; 
            }
        }
    }
}

