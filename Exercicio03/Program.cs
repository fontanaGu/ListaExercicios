namespace Exercicio03
//Crie um programa para calcular o volume de um "cilindro"
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, altura, cilindro;

            Console.WriteLine("Calcular o volume de um cilindro");

            Console.WriteLine("Digite o raio do cilindro: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Math.Pow(raio, 2);

            cilindro = Math.PI * raio * altura;
            Console.WriteLine("O volume do cilindro é: " + cilindro);
            Console.ReadKey();



        }
    }
}
