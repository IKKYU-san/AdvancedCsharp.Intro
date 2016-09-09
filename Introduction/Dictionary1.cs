using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    public class Apartment { 
        public string Address { get; set; }
    }

    class Dictionary1
    {
        public static void Run()
        {
            Dictionary<int,Apartment> apartment = new Dictionary<int,Apartment>();
           
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
                            Apartment newApartment = new Apartment();
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