using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    class HashSet1
    {

        public static void Run()
        {

            Dictionary<string, int> people = new Dictionary<string, int>();

            while (true)
            {
                Console.Write("Ange namn,ålder(int): ");
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

                int parsedNumber;
                if (int.TryParse(inputValues[1], out parsedNumber))
                {
                    try
                    {
                        if (people.ContainsKey(inputValues[0]))
                        {
                            people[inputValues[0]] = parsedNumber;
                        }
                        else
                        {
                            people.Add(inputValues[0], parsedNumber);
                        }

                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Wrong input, try again");
                        continue;
                    }
                }
            }
            int ageSum = 0;
            foreach (var person in people)
            {
                ageSum += person.Value;
            }
            int numberOfPersons = people.Count;


            Console.WriteLine($"Summa: {ageSum}");
            Console.WriteLine($"Antal personer: {numberOfPersons}");
        }
    }
}