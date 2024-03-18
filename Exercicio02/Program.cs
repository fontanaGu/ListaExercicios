namespace Exercicio02
//Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal temperaturaFahrenheit, temperaturaCelsius;

            Console.WriteLine("Converter temperatura de ºFahrenheit para ºCelsius");

            Console.WriteLine("Digite a temperatura em ºFahrenheit: ");
            temperaturaFahrenheit = Convert.ToDecimal(Console.ReadLine());

            temperaturaCelsius = (temperaturaFahrenheit - 32) * 5 / 9;
            Console.WriteLine("A temperatura em ºCelsius fica: " +  temperaturaCelsius);
            Console.ReadKey();
        }
    }
}
