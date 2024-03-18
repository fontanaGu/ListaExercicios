namespace Exercicio06
//Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaCelsius, temperaturaFahrenheit;

            Console.WriteLine("Conversor de temperatura graus celsius para fahrenheit.");
            Console.WriteLine("Digite o valor da temperatura em graus celsius:");
            temperaturaCelsius = Convert.ToDecimal(Console.ReadLine());

            temperaturaFahrenheit = (temperaturaCelsius * 9 /5) + 32;
            Console.WriteLine("A temperatura em fahrenheit é: " + temperaturaFahrenheit);
            Console.ReadKey();
        }
    }
}
