using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CarPark.CarException;
using CarPark.transport_type;

namespace CarPark.utility
{
    public class TransportCollectionUtility : List<Transport>
    {
        private List<Transport> listTransport;
        List<string> fieldsName = new List<string>();


        public TransportCollectionUtility(List<Transport> transports)
        {
            this.listTransport = transports;
        }
        public List<Transport> AddTransport(Transport transport)
        {
            if (transport == null)
            {
                throw new AddException($"Collection can't consists transport without required fields");
            }
            listTransport.Add(transport);
            Console.WriteLine($"Add {transport.GetType().Name}");
            return listTransport;
        }

        public List<Transport> UpdateTransportWithSerialNumber(Transport newTransport, long serialNumber)
        {
            var result = listTransport.Any(transport => transport.Engine.SerialNumber.Equals(serialNumber));
            if (result)
            {
                listTransport.RemoveAll(transport =>
                transport.Engine.SerialNumber.Equals(serialNumber));
                listTransport.Add(newTransport);
            }
            else
            {
                throw new UpdateException("ne mogy");
            }


            return listTransport;
        }


        public List<Transport> RemoveTransportWithSerialNumber(Transport newTransport, long serialNumber)
        {
            var result = listTransport.Any(transport => transport.Engine.SerialNumber.Equals(serialNumber));
            if (result)
            {
                listTransport.RemoveAll(transport =>
                transport.Engine.SerialNumber.Equals(serialNumber));
            }
            else
            {
                throw new UpdateException("ne mogy");
            }


            return listTransport;
        }

        public void GetTransportByParameter(string parameter, string value)
        {
            foreach (Transport transport in listTransport)
            {


                foreach (var field in GetFields(transport))
                {


                    Console.WriteLine(field.ToString());

                }

            }
        }

        private IEnumerable<string> GetFields(object obj)
        {
            var fields = obj.GetType()
                .GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
                .ToList();

            if (fields.Count() == 0)
            {
                fieldsName.Add(obj.ToString());
                
            }
            else
            {
                foreach (var localField in fields)
                {
                    GetFields(localField);
                }
            }
            return fieldsName;
        }
    }
}
