﻿namespace Exercicio01.ConsoleApp
//Crie um programa para calcular o volume de uma caixa retangular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal comprimento, largura, altura, volume;

            Console.WriteLine("Calcular o volume de uma caixa");

            Console.WriteLine("Digite o comprimento da caixa: ");
            comprimento = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa: ");
            largura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite a altura da caixa: ");
            altura = Convert.ToDecimal(Console.ReadLine()); 

            volume = comprimento * largura * altura;
            Console.WriteLine("O volume da caixa é: " + volume);
            Console.ReadKey();
        }
    }
}
