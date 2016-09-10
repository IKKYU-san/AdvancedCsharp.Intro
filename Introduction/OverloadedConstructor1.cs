using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.Intro.Introduction
{
    class OverloadedConstructor1
    {
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public bool Gender { get; set; }

            public Person()
            {
            }

            public Person(string name)
            {
                Name = name;
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public Person(string name, int age, bool gender)
            {
                Name = name;
                Age = age;
                Gender = gender;
            }

            public override string ToString()
            {
                string output = "En okänd person som vi inte vet åldern på";
                if (Name != null && Age > 0 && Gender)
                {
                    string gender = Gender ? "tjej" : "kille";
                    output = $"{Name} är en {gender} på {Age} år";
                }

                else if (Name != null && Age > 0)
                {
                    output = $"{Name} är {Age} år";
                }

                else if (Name !=  null)
                {
                    output =  $"{Name}, ingen vet hur gammal han är";
                }
                return output;
            }
        }
        public static void Run()
        {
            var p1 = new Person();
            var p2 = new Person("Kalle");
            var p3 = new Person("Lisa", 35);
            var p4 = new Person("Lisa", 35, true);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p3.ToString());
            Console.WriteLine(p4.ToString());
        }
    }
}
