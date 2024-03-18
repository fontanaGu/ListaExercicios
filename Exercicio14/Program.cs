namespace Exercicio14
//Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui. Considere sempre anos completos, e que um ano possui 365 dias.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //V
            string nome;
            int idade, diasDeVida   ;

            //E
            Console.WriteLine("Digite o seu nome:   ");
            nome = Console.ReadLine();

            Console.WriteLine((nome) + "digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            

            //P
            diasDeVida = idade * 365;
            Console.WriteLine((nome) + "Você já viveu" + (diasDeVida) + "dias");
            Console.ReadKey();

            //S
           
        }
    }
}
