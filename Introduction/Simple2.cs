using System;

namespace AdvancedCsharp.Intro.Introduction
{
    class Simple2
    {

        public static void Run()
        {

            Console.Write("Ange tal1: ");
            var number1 = GetValue();

            Console.Write("Ange tal2: ");
            var number2 = GetValue();

            Console.Write("Ange tal3: ");
            var number3 = GetValue();

            var result = number1 + number2 + number3;

            Console.WriteLine($"Summa av talen är {result}");

        }

        public static int GetValue()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Ange en siffra!");
            }
            return number;
        }
    }
}
