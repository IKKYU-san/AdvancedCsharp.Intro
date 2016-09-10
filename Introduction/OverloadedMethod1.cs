using System;
using System.Linq;
using System.Text;

namespace AdvancedCsharp.Intro.Introduction
{
    class OverloadedMethod1
    {
        public static void Run()
        {
            Console.Write("Please enter a name: ");
            string name = Console.ReadLine();

            ShoutName(name);
            ShoutName(name, 3);
            ShoutName(name, 3, true);
        }

        public static void ShoutName(string s)
        {
            Console.WriteLine(s);
        }

        public static void ShoutName(string s, int repeat)
        {
            string name = s.PadRight(s.Length + 1);
            string output = String.Concat(Enumerable.Repeat(name, repeat));
            Console.WriteLine(output);
        }

        public static void ShoutName(string s, int repeat, bool addStars = false)
        {
            if (addStars)
            {
                string name = s.PadRight(s.Length + 1);
                string output = String.Concat(Enumerable.Repeat(name, repeat));
                Console.WriteLine($"*********{output.TrimEnd()}*********");
            }
        }
    }
}
