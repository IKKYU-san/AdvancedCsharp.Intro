using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    class Person<Tname, Tage>
    {
        public Tname Name { get; set; }
        public Tage Age { get; set; }

        public Person(Tname name, Tage age)
        {
            Name = name;
            Age = age;
        }
    }

    class Generics1
    {

        public static void Run()
        {

            List<Person<string, int>> people = new List<Person<string, int>>();

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

                        Person<string, int> person = new Person<string, int>(inputValues[0], parsedNumber);
                        people.Add(person);
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
                ageSum += person.Age;
            }

            Console.WriteLine($"Summa av ålder: {ageSum}");
        }
    }
}