using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp.Intro.Introduction
{
    class Person
    {

    }

    class Generics1
    {

        public static void Run()
        {

            List<Person> persons = new List<Person>();
            int parsedNumber;

            while (true)
            {
                Console.Write("Ange namn,ålder(int): ");
                var inputValue = Console.ReadLine();

                if (inputValue == "")
                {
                    break;
                }

                // use .split(',') and try to parse name,age and verify age is a number.
                if (int.TryParse(inputValue, out parsedNumber))
                {
                    numberList.Add(parsedNumber);

                }
            }
            var ageSum = numberList.Where(x => x < 100);

            Console.WriteLine($"Summa av åler: {lowNumbers.Sum()}");
        }
    }
}