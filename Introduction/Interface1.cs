using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.Intro.Introduction
{
    class Interface1
    {
        interface IBuilding
        {
            void LongDescription();
        }

        class Apartment : IBuilding
        {
            public string Address { get; set; }
            public Apartment(string _address)
            {
                Address = _address;
            }
            public void LongDescription()
            {
                Console.WriteLine($"This is an apartment with address {Address}");
            }
        }

        class House : IBuilding
        {
            public string Address { get; set; }
            public House(string _address)
            {
                Address = _address;
            }

            public void LongDescription()
            {
                Console.WriteLine($"This is a house with address {Address}");
            }
        }

        public static void Run()
        {
            Apartment apartment1 = new Apartment("Storgatan 35");
            Apartment apartment2 = new Apartment("Lilla Torget 15");
            House house1 = new House("Villavägen 3");
            Apartment apartment3 = new Apartment("Motgången 35B");
            House house2 = new House("Hästskobacken 2");

            List<IBuilding> buildings = new List<IBuilding>();
            buildings.Add(apartment1);
            buildings.Add(apartment2);
            buildings.Add(house1);
            buildings.Add(apartment3);
            buildings.Add(house2);

            PrintBuildings(buildings);
        }

        static void PrintBuildings(List<IBuilding> _buildings)
        {
            foreach (var item in _buildings)
            {
                item.LongDescription();
            }
        }
    }
}
