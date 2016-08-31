using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedCsharp.Intro.Introduction
{
    class Simple4
    {

        public static void Run()
        {

            List<int> numberList = new List<int>();
            int parsedNumber;

            while (true)
            {
                Console.Write("Ange ett tal: ");
                var inputValue = Console.ReadLine();

                if (inputValue == "")
                {
                    break;
                }

                if (int.TryParse(inputValue, out parsedNumber))
                {
                    numberList.Add(parsedNumber);
                }
            }
            var lowNumbers = numberList.Where(x => x < 100);
            var highNumbers = numberList.Where(x => x >= 100);

            Console.WriteLine($"Summan av de tal som är lägre än 100: {lowNumbers.Sum()}");
            Console.WriteLine($"Summan av de tal som är högre än 100: {highNumbers.Sum()}");
        }
    }
}