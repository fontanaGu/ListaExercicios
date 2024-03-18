namespace Exercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci");

            Console.WriteLine("Digite um número:");
            int limite = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;

            Console.WriteLine("Sequência de Fibonacci até " + limite + ":");

            while (c <= limite)
            {
                Console.Write(c + " ");
                a = b;
                b = c;
                c = a + b;
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
