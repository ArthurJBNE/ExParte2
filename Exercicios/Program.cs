using System;

namespace ExerciciosFinanceiros
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercícios de Cálculos Financeiros");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Cálculo de Rendimento Simples");
                Console.WriteLine("2. Cálculo de Rendimento Mensal (6 meses)");
                Console.WriteLine("3. Cálculo de Rendimento com Entrada de Dados");
                Console.WriteLine("4. Cálculo de Rendimento com Resgate");
                Console.WriteLine("5. Cálculo de Valor Presente");
                Console.WriteLine("0. Sair");
                Console.WriteLine();
                Console.Write("Escolha um problema (0-5): ");

                if (int.TryParse(Console.ReadLine(), out int opcao))
                {
                    Console.Clear();
                    switch (opcao)
                    {
                        case 0:
                            return;
                        case 1:
                            Problema1.CalcularRendimento();
                            break;
                        case 2:
                            Problema2.CalcularRendimentoMensal();
                            break;
                        case 3:
                            Problema3.CalcularRendimentoEntrada();
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
                else
                {
                    Console.WriteLine("Opção inválida! Digite um número entre 0 e 5.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
