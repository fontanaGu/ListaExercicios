namespace Exercicio13
    //padaria hotpao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantidadePaes, quantidadeBroas, totalArrecadado, valorPoupanca;

            Console.WriteLine("Padaria Hotpão");

            Console.WriteLine("Digite a quantidade de pães: ");
            quantidadePaes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de broas: ");
            quantidadeBroas = Convert.ToDouble(Console.ReadLine());

            //total arrecadado
            totalArrecadado = (quantidadePaes * 0.12) + (quantidadeBroas * 1.50);

            //poupanca
            valorPoupanca = totalArrecadado * 0.10;

            Console.WriteLine("Total arrecadado: " + totalArrecadado);
            Console.WriteLine("Total na poupança: " + valorPoupanca);
            Console.ReadKey();

        }
    }
}
