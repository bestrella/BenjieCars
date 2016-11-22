using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenjiePetCare
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleDALController vehicleDAL = new VehicleDALController();

            List<Vehicle> vehiclesFromDB = vehicleDAL.GetAll();

            foreach (var item in vehiclesFromDB)
            {
                Console.WriteLine("========================================");
                Console.WriteLine(item.Chassis);
                Console.WriteLine(item.Color);
                Console.WriteLine(item.Make);


            }

            Console.ReadLine();
        }
    }

    //LIB ONLY (DAL - data acces layer)

    // MODEL - vehicle

    class Vehicle {
        public string Chassis { get; set; }
        public string Color { get; set; }
        public string Make { get; set; }

    }

    class VehicleDALController {
        public Vehicle Get(string Chassis)
        {
            Console.WriteLine("assume query data from to db");

            Vehicle v = new Vehicle();
            v.Chassis = "XDADASDA";
            v.Color = "red";
            v.Make = "honda";
            return  v;
        }
     
        public void  Add(Vehicle v)
        {
            Console.WriteLine("assume save to db");
        }

        public List<Vehicle> GetAll()
        {
            List<Vehicle> vehiclelist = new List<Vehicle>();

            Console.WriteLine("assume query data from to dbxx");

            Vehicle mokVehicle = new Vehicle();
            Vehicle jickingVehicle = new Vehicle();
            Vehicle myVehicle = new Vehicle();


            mokVehicle.Color = "red";
            mokVehicle.Chassis = "chassi";
            mokVehicle.Make = "Sony";


            jickingVehicle.Chassis = "chaseXXX";
            jickingVehicle.Color = "Black";
            jickingVehicle.Make = "XxArt";

            myVehicle.Chassis = "ChaseMen";
            myVehicle.Color = "pink";
            myVehicle.Make = "honda";


            vehiclelist.Add(myVehicle);
            vehiclelist.Add(mokVehicle);
            vehiclelist.Add(jickingVehicle);



            return vehiclelist;


        }
    }

}
