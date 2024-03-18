using System;

namespace Exercicio28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada de multiplicação do 1 até o 10:");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write($"{i} x {j} = {i * j,-3}   ");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}
