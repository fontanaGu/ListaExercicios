namespace Exercicio05
//Crie um programa para calcular o volume de uma esfera
// V= 4 / 3 * PI * raio 3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio, volume;

            Console.WriteLine("Calcular o volume da esfera");

            Console.WriteLine("Digite o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());
            Math.Pow(raio, 3);

            volume = 4 / 3 * Math.PI * raio;
            Console.WriteLine("Volume é igual a: " + volume);
            Console.ReadKey();
        }
    }
}
