using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    class Inheritance1
    {
        public class Building
        {
            public string address;
            public string type;
        }

        public class House : Building
        {
            public House(string _address)
            {
                address = _address;
                type = "ett hus";
            }
        }

        public class Apartment : Building
        {

        }

        public class OwndedApartment : Apartment
        {
            public OwndedApartment(string _address)
            {
                address = _address;
                type = "en bostadsrätt";
            }
        }

        public class RentedApartment : Apartment
        {
            public RentedApartment(string _address)
            {
                address = _address;
                type = "en hyresrätt";
            }
        }

        public static void PrintBuildings(List<Building> buildings)
        {
            foreach (var building in buildings)
            {
                Console.WriteLine($"{building.address} ({building.type})");
            }
        }

        public static void Run()
        {
            List<Building> buildings = new List<Building>();
            buildings.Add(new House("Villavägen 3"));
            buildings.Add(new OwndedApartment("Storgatan 100"));
            buildings.Add(new RentedApartment("Erik Dahlbergsgatan 10"));
            buildings.Add(new House("Fjällgatan 2B"));
            buildings.Add(new House("Strandvägen 20"));
            buildings.Add(new House("Lundabacken 2"));


            PrintBuildings(buildings);
            Console.ReadKey();
        }
    }
}
