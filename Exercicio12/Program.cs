namespace Exercicio12
//A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.
//Area - comprimento x largura

{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal area, comprimento, largura;

            Console.WriteLine("Algoritmo para ler as dimensões e exibir a área");

            Console.WriteLine("Digite o comprimento: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            area = comprimento * largura;
            Console.WriteLine("Area é igual a: " + area);
            Console.ReadKey();


        }
    }
}
