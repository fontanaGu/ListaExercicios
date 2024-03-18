namespace Exercicio04
    //Crie um programa para calcular o consumo de combustível por Km.
    //Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo.Deverá ser informado o Consumo de Combustível.
    // consumo = quilometragemInicial - quilometragemFinal / consumo de combustivel.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal quilometragemInicial, quilometragemFinal, consumoDeCombustivel, consumo;

            Console.WriteLine("Calcular o consumo de combustível/km");

            Console.WriteLine("Digite a quilometragem inicial:  ");
            quilometragemInicial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a quilometragem final: ");
            quilometragemFinal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Informe o consumo de combustivel: ");
            consumoDeCombustivel = Convert.ToDecimal(Console.ReadLine());

            consumo = quilometragemInicial - quilometragemFinal / consumoDeCombustivel;
            Console.WriteLine("O consumo por km é de: " + consumo);
            Console.ReadKey();
        }
    }
}
