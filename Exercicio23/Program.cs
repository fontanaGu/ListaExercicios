namespace Exercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma dos Impares");

            int soma = 0;

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine("A soma dos números ímpares múltiplos de três entre 1 e 500 é: " + soma);
            Console.ReadKey();
        }
    }
}
