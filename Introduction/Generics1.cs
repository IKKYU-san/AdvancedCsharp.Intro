using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Generics1
    {

        public static void Run()
        {

            List<Person> people = new List<Person>();

            while (true)
            {
                Console.Write("Ange namn,ålder(int): ");
                var inputString = Console.ReadLine();

                if (inputString == "")
                {
                    break;
                }

                Person person = new Person();
                string[] inputValues = inputString.Split(',');

                person.Name = inputValues[0];

                int parsedNumber;
                if (int.TryParse(inputValues[1], out parsedNumber))
                {
                    person.Age = parsedNumber;
                    people.Add(person);
                }
            }

            int ageSum = 0;
            foreach (var person in people)
            {
                ageSum += person.Age;
            }

            Console.WriteLine($"Summa av åler: {ageSum}");
        }
    }
}