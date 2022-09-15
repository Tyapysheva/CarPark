using CarPark.utility;

namespace CarPark.transport_parts
{
    class Chassis
    {
        private int numberOfWheels;
        private long number;
        private float permissibleLoad;

        public Chassis(int numberOfWheels, long number, float permissibleLoad)
        {
            NumberOfWheels = numberOfWheels;
            Number = number;
            PermissibleLoad = permissibleLoad;
        }

        public virtual int NumberOfWheels { get => numberOfWheels; 
            set
            {
                CompareUtil.checkFieldWithSign("Number Of Wheels", value, CompareSign.GREATER, 0);
                numberOfWheels = value;
            }
        }
        public virtual long Number { get => number; 
            set
            {
                CompareUtil.checkFieldWithSign("Number", value, CompareSign.GREATER, 0);
                number = value;
            }
        }
        public virtual float PermissibleLoad { get => permissibleLoad; 
            set
            {
                CompareUtil.checkFieldWithSign("Permissible Load", value, CompareSign.GREATER, 0);
                permissibleLoad = value;
            }
        }
    }
}

