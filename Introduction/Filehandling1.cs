using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.Intro.Introduction
{
    class Filehandling1
    {
        class Person
        {
            public string SocialSecurityNumber { get; set; }
            public string FirstName { get; set; }
            public string FavoriteColor { get; set; }

            public override string ToString()
            {
                return $"{SocialSecurityNumber}\t{FirstName}\t{FavoriteColor}";
            }
        }

        public static void Run()
        {
            List<Person> people = new List<Person>();

            // Read all people into list
            foreach (string line in File.ReadAllLines(@"Introduction\PersonNummer.txt"))
            {
                string[] field = line.Split(',');
                Person person = new Person();

                person.SocialSecurityNumber = field[0];
                person.FirstName = field[1];
                person.FavoriteColor = field[2];

                people.Add(person);
            }

            // Print out all the people
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
