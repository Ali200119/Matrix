using System;

namespace Matrix_World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Wake up {name}...");
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The matrix has you...");

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Follow the White Rabbit...");
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Knok Knok, {name}");
        }
    }
}
