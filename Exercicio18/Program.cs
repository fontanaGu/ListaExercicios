namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Algortimo que lê 3 valores... ");

            Console.WriteLine("Digite o primeiro valor inteiro:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor inteiro:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor inteiro:");
            int c = int.Parse(Console.ReadLine());

            // Encontrando o maior valor
            int max = Math.Max(a, Math.Max(b, c));

            // Encontrando o menor valor
            int min = Math.Min(a, Math.Min(b, c));

            // Encontrando o valor do meio
            int mid = (a + b + c) - (max + min);

            // Imprimindo em ordem decrescente
            Console.WriteLine("Em ordem decrescente: {0}, {1}, {2}", max, mid, min);
            Console.ReadKey();
        }
    }
}
