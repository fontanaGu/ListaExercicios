namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B");

            Console.WriteLine("Digite o valor de A:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            int b = int.Parse(Console.ReadLine());

            int c;

            if (a == b)
            {
                c = a + b;
                Console.WriteLine("Os valores são iguais. A soma de A e B é: " + c);
                Console.ReadKey();
            }
            else
            {
                c = a * b;
                Console.WriteLine("Os valores são diferentes. A multiplicação de A por B é: " + c);
                Console.ReadKey();
            }
        }
    }
}
