namespace Exercicio10
//Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pesoPrimeiraNota, pesoSegundaNota, primeiraNota, SegundaNota, mediaPonderada;

            Console.WriteLine("Media ponderada");

            Console.WriteLine("Digite a primeira nota: ");
            primeiraNota = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o peso da primeira prova: ");
            pesoPrimeiraNota = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Digite a segunda nota: ");
            SegundaNota = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o peso da segunda prova: ");
            pesoSegundaNota = Convert.ToDecimal(Console.ReadLine());

            mediaPonderada = (pesoPrimeiraNota * primeiraNota) + (pesoSegundaNota + SegundaNota) / pesoPrimeiraNota + pesoSegundaNota;
            Console.WriteLine("Media ponderada: " + mediaPonderada);
            Console.ReadKey();

        }
    }
}
