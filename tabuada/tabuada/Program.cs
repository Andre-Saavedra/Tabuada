using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza um número");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nTabuada do {n}\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
            Console.ReadKey();
        }
    }
}
