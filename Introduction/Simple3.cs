using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedCsharp.Intro.Introduction
{
    class Simple3
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

                if(int.TryParse(inputValue, out parsedNumber))
                {
                    numberList.Add(parsedNumber);

                }
            }
            Console.WriteLine($"Summa av talen är: {numberList.Sum()}");
        }
    }
}
