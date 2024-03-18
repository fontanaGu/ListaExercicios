namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMC");

            Console.WriteLine("Digite o peso:");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura:");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("IMC: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
                Console.ReadKey();
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
                Console.ReadKey();
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Condição: Acima do peso");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Condição: Obeso");
                Console.ReadKey();
            }
        }
    }
}
