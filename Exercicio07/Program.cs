namespace Exercicio07
{
    //calcular o salario total do vendedor. salario base + comissoes
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            decimal salarioBase, totalDeVendas, salarioTotal, comissaoTotal;

            Console.WriteLine("Salario total do vendedor");

            Console.WriteLine("Digite o salario base do vendedor:");
            salarioBase = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o total de vendas realizadas: ");
            totalDeVendas = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o % da comissão: ");
            comissaoTotal = Convert.ToDecimal(Console.ReadLine());

            salarioTotal = salarioBase + (totalDeVendas * comissaoTotal / 100);
            Console.WriteLine("O salario final é: " +  salarioTotal);
            Console.ReadKey();



        }
    }
}
