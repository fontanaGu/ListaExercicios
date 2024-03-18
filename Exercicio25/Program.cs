namespace Exercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial");

            Console.WriteLine("Digite um número para calcular o fatorial:");
            int a = int.Parse(Console.ReadLine());

            int fatorial = 1;
            string sequencia = $"{a}! = ";

            for (int i = a; i >= 1; i--)
            {
                fatorial *= i;
                sequencia += i;

                if (i != 1)
                {
                    sequencia += " X ";
                }
            }

            sequencia += $" = {fatorial}";
            Console.WriteLine(sequencia);
            Console.ReadKey();
        }
    }
}
