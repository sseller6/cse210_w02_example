using System;

// We need this for lists
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crate a list of strings.
            List<string> names = new List<string>();
            names.Add("Bob");
            names.Add("Dan");
            names.Add("Tim");
            
            // Loops through list and prints it out.
            names.ForEach(name => Console.Write(name + " "));

            // Crate a list of strings that you KNOW what will be in the list.
            List<string> stuff = new List<string>{"a", "b", "c", "d"};

            char aSingleCharacter = 'a';
            Console.WriteLine($"This is a single character: {aSingleCharacter}");

            int x = 5;
            int y = 7;

            int result = Adder(x, y); // 12

            int result2 = Adder(10, 46); // 56

            Console.WriteLine($"{x} + {y} = {result}");
        }

        // How to create a function.
        static int Adder(int a, int b)
        {
            return a + b;
        }
    }
}