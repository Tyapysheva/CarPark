using CarPark.utility;

namespace CarPark.transport_parts
{
    public class Transmission
    {
        private TypeTransmission typeTransmission;
        private byte numberOfGears;
        private string manufacturer = "";

        public Transmission()
        {
        
        }

        public Transmission(TypeTransmission typeTransmission, byte numberOfGears, string manufacturer)
        {
            TypeTransmission = typeTransmission;
            NumberOfGears = numberOfGears;
            Manufacturer = manufacturer;
        }

        public virtual TypeTransmission TypeTransmission
        {
            get => typeTransmission;
            set
            {
                CompareUtil.checkFieldNotNull("Transmission", value);
                typeTransmission = value;
            }
        }
        public virtual byte NumberOfGears
        {
            get => numberOfGears; 
            set
            {
                CompareUtil.checkFieldWithSign("Number Of Gears", value, CompareSign.GREATER, 0);
                numberOfGears = value;
            }
        }
        public virtual string Manufacturer
        {
            get => manufacturer; 
            set
            {
                CompareUtil.checkFieldNotNull("Manufacturer", value);
                manufacturer = value;
            }
        }
        public override string? ToString()
        {
            return "\nTransmission: \nType = " + TypeTransmission +
                "; Number Of Gears = " + NumberOfGears + "; Manufacturer = " + Manufacturer;
        }
    }
}

