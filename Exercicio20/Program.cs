namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Par ou Impar");

            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é par.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O número é ímpar.");
                Console.ReadKey();
            }
        }
    }
}
