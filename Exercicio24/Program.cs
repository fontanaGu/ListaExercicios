namespace Exercicio24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine("Digite um número de 1 a 10:");
            int n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 10)
            {
                Console.WriteLine("Número inválido. Por favor, digite um número de 1 a 10.");
                return;
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i} x {n} = {i * n}");
                Console.ReadKey();
            }
        }
    }
}
