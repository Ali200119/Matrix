using System;

namespace Matrix_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Wake up, {name}...");

            Console.Clear();

            Console.WriteLine("The Matrix has you...");

            Console.Clear();

            Console.WriteLine("Follow the white rabbit.");

            Console.Clear();

            Console.WriteLine($"Knock, knock, {name}.");
        }
    }
}
