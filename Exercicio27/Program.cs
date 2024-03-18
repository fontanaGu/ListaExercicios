namespace Exercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                  Console.ReadKey();
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.ReadKey();
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine(i);
                    Console.ReadKey();
                }
            }
        }
    }
}
