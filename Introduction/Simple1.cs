using System;

namespace AdvancedCsharp.Intro.Introduction
{
    class Simple1
    {

        public static void Run()
        {
            Console.Write("Ange tal1: ");
            var number1 = int.Parse(Console.ReadLine());

            Console.Write("Ange tal2: ");
            var number2 = int.Parse(Console.ReadLine());

            Console.Write("Ange tal3: ");
            var number3 = int.Parse(Console.ReadLine());

            var result = number1 + number2 + number3;

            Console.WriteLine($"Summa av talen är {result}");
            
        }
    }
}
