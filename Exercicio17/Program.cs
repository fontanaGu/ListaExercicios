namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B < C");

            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            int c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("A soma de A + B é menor que C.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("A soma de A + B não é menor que C.");
                Console.ReadKey();
            }
        }
    }
}
