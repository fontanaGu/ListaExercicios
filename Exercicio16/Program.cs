namespace Exercicio16
//Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15%. Após o aumento, desconte 8% de impostos. Imprima o salário inicial, o salário com o aumento e o salário final.
//aumento = 0.15 * salario
//salarioFinal = salarioInicial + salarioAumento - (0.08 * salario);
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salarioInicial, salarioAumento, salarioFinal;

            Console.WriteLine("Novo salário");

            Console.WriteLine("Digite o seu salário inicial: ");
            salarioInicial = Convert.ToDouble(Console.ReadLine());

            salarioAumento = salarioInicial * 0.15;         

            salarioFinal = salarioInicial + salarioAumento - (0.08 * salarioInicial);
           

            Console.WriteLine("O salário final com desconto do imposto é: " + salarioFinal);
            Console.ReadKey();
        }
    }
}
