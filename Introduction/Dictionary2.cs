using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    // I didnt get the assignment requirements. They were too unclear.
    class Dictionary2
    {
        class Building
        {
            public string Address { get; set; }
        }

        public static void Run()
        {
            Dictionary<int, Building> apartment = new Dictionary<int, Building>();

            while (true)
            {
                Console.Write("Ange lägenhetsnummer(int),address: ");
                var inputString = Console.ReadLine();

                if (inputString == "")
                {
                    break;
                }

                string[] inputValues;
                try
                {
                    inputValues = inputString.Split(',');
                    if (inputValues[0] == "" || inputValues[1] == "")
                    {
                        Console.WriteLine("Wrong input, try again");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input, try again");
                    continue;
                }
                string address = inputValues[1];

                int parsedNumber;
                if (int.TryParse(inputValues[0], out parsedNumber))
                {
                    try
                    {
                        if (apartment.ContainsKey(parsedNumber))
                        {
                            apartment[parsedNumber].Address = address;
                        }
                        else
                        {
                            Building newApartment = new Building();
                            newApartment.Address = address;
                            apartment.Add(parsedNumber, newApartment);
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Wrong input, try again");
                        continue;
                    }
                }
            }

            Console.WriteLine($"Antal lägenheter i listan: {apartment.Count}");
            if (apartment.ContainsKey(1234))
            {
                Console.WriteLine($"Lägenhet med nummer 1234: {apartment[1234].Address}");
            }

        }
    }
}