using System;
using System.Collections.Generic;

namespace AdvancedCsharp.Intro.Introduction
{
    class HashSet2
    {
        public class Person : IEquatable<Person>
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }

            public bool Equals(Person other)
            {
                return this.Name.Equals(other.Name);
            }
        }

        public static void Run()
        {

            HashSet<Person> people = new HashSet<Person>();
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

                string name = inputValues[0].ToLower();
                int age;
                if (int.TryParse(inputValues[1], out age))
                {
                    try
                    {
                        if (people.Count == 0)
                        {
                            people.Add(new Person() { Name = name, Age = age });
                        }
                        else
                        {
                            foreach (var person in people)
                            {
                                if (person.Name == name)
                                {
                                    person.Age = age;
                                }
                                else
                                {
                                    people.Add(new Person() { Name = name, Age = age });
                                }
                            }
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
                ageSum += person.Age;
            }
            int numberOfPersons = people.Count;


            Console.WriteLine($"Summa: {ageSum}");
            Console.WriteLine($"Antal personer: {numberOfPersons}");
        }
    }
}