using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using System.Xml.Serialization;
using CarPark.transport_parts;
using CarPark.transport_type;
using CarPark.utility;
using CarPark.xml;

namespace Carpark
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(400F, 20.0F, TypeEngine.TRUCK_ENGINE, 123);
            Chassis chassis = new Chassis(16, 43, 55000);
            Transmission transmission = new Transmission(TypeTransmission.MANUAL, 7, "manufacture");
            Truck truck = new Truck(engine, chassis, transmission);

            Engine engine1 = new Engine(230F, 6.0F, TypeEngine.BUS_ENGINE, 125);
            Chassis chassis1 = new Chassis(8, 46, 11000);
            Transmission transmission1 = new Transmission(TypeTransmission.AUTOMATIC, 4, "manufacture");
            Bus bus = new Bus(engine1, chassis1, transmission1);

            Engine engine2 = new Engine(50F, 0.04F, TypeEngine.SCOOTER_ENGINE, 127);
            Chassis chassis2 = new Chassis(2, 23, 250);
            Transmission transmission2 = new Transmission(TypeTransmission.CONTINUOSLY_VARIABLE, 2, "manufacture");
            Scooter scooter = new Scooter(engine2, chassis2, transmission2);

            Engine engine3 = new Engine(200F, 4F, TypeEngine.CAR_ENGINE, 127);
            Chassis chassis3 = new Chassis(4, 30, 6000);
            Transmission transmission3 = new Transmission(TypeTransmission.CONTINUOSLY_VARIABLE, 15, "manufacture");
            PassengerCar passengerCar = new PassengerCar(engine3, chassis3, transmission3);

            Engine engine4 = new Engine(200F, 4F, TypeEngine.CAR_ENGINE, 127);
            Chassis chassis4 = new Chassis(4, 30, 6000);
            Transmission transmission4 = new Transmission(TypeTransmission.AUTOMATIC, 15, "manufacture");
            PassengerCar passengerCar2 = new PassengerCar(engine4, chassis4, transmission4);


            Console.WriteLine(truck);
            Console.WriteLine(bus);
            Console.WriteLine(scooter);
            Console.WriteLine(passengerCar);

            List<Transport> listTransport = new List<Transport>();
            listTransport.Add(truck);
            listTransport.Add(bus);
            listTransport.Add(scooter);
            listTransport.Add(passengerCar);
            listTransport.Add(passengerCar2);


            List<Transport> truckAndBus = new List<Transport>();
            truckAndBus.AddRange(SorterTransportUtility.selectTransportFromListByType(listTransport, typeof(Bus)));
            truckAndBus.AddRange(SorterTransportUtility.selectTransportFromListByType(listTransport, typeof(Truck)));

            

            WorkWithXML.WritePowerTypeNumberOfEngineInXml(truckAndBus, "Sortedfile.xml");
            WorkWithXML.WriteTransportsToXml(SorterTransportUtility.selectTransportWithEngineCapacity(listTransport,1.5),"transport.xml");
            WorkWithXML.WriteTransportsGroupByToXml(SorterTransportUtility.selectTransportGroupByTransmissionType(listTransport), "group.xml");
        }


    }

}

