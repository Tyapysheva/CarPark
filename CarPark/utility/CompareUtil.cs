using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPark.exception;
using CarPark.transport_parts;
using CarPark.transport_type;

namespace CarPark.utility
{
    public static class CompareUtil
    {
        public static void checkFieldWithSign(string fieldName, double obj, CompareSign sign, double num)
        {
            switch (sign)
            {
                case CompareSign.GREATER:
                    if (obj < num)
                    {
                        throw new ComparisonException($"{fieldName} value={obj} must be greater than {num}");
                    }
                    else
                    {
                        break;
                    }
                case CompareSign.LESS:
                    if (obj > num)
                    {
                        throw new ComparisonException($"{fieldName} value={obj} must be less than {num}");
                    }
                    else
                    {
                        break;
                    }

                default:
                    break;
            }
        }
        public static void checkFieldNotNull(string fieldName, object obj)
        {
            if (obj.Equals(null))
            {
                throw new ComparisonException($"{fieldName} must be not null");
            }
        }

        public static void checkTypeEngine(string fieldName, object obj, TypeEngine type)
        {
            if (!obj.Equals(type))
            {
                throw new ComparisonException($"{fieldName} must be {type}");
            }

        }

        public static void checkTypeTransmission(string fieldName, Type obj, TypeTransmission type)
        {
            switch (type)
            {
                case TypeTransmission.MANUAL:
                case TypeTransmission.AUTOMATIC:

                    if (typeof(Scooter).Equals(obj) || typeof(PassengerCar).Equals(obj))
                    {
                        throw new ComparisonException($"{fieldName} must be {type}");
                    }
                    else
                    {
                        break;
                    }

                case TypeTransmission.CONTINUOSLY_VARIABLE:
                    if (obj.Equals(typeof(Truck)) || obj.Equals(typeof(Bus)) || obj.Equals(typeof(PassengerCar)))
                    {
                        throw new ComparisonException($"{fieldName} must be {type}");
                    }
                    else
                    {
                        break;
                    }

                default:
                    break;
            }
        }
    }

    public enum CompareSign
    {
        GREATER,
        LESS
    }
}
