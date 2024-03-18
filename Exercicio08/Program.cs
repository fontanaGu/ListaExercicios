namespace Exercicio08
//Crie um programa para calcular o volume de uma lata de óleo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, volume;

            Console.WriteLine("Calcular o volume da lata de óleo");

            Console.WriteLine("Digite o valor do raio:");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura:");
            altura = Convert.ToDouble(Console.ReadLine());

            Math.Pow(raio, 2);

            volume = Math.PI     * raio * altura;

            Console.WriteLine("O volume é: " + volume);
            Console.ReadLine();


        }
    }
}
