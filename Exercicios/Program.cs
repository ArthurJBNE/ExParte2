using System;

namespace Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o exercício (1-5):");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Problema1.CalcularRendimento();
                    break;
                case 2:
                    Problema2.CalcularRendimentoMensal();
                    break;
                case 3:
                    Problema3.CalcularRendimentoComEntrada();
                    break;
                case 4:
                    Problema4.CalcularRendimentoComResgate();
                    break;
                case 5:
                    Problema5.CalcularValorPresente();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
