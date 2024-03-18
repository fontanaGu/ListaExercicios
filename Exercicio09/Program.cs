namespace Exercicio09
//Crie um programa para calcular a média harmônica das notas de um Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal notaUm, notaDois, notaTres, mediaHarmonica;

            Console.WriteLine("Calcular a média harmônica do aluno.");

            Console.WriteLine("Digite a primeira nota do aluno: ");
            notaUm = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno: ");
            notaDois = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota do aluno: ");
            notaTres = Convert.ToDecimal(Console.ReadLine());

            mediaHarmonica = (notaUm + notaDois + notaTres) / 3;
            Console.WriteLine("A média harmônica é: " +  mediaHarmonica);
            Console.ReadKey();


        }
    }
}
