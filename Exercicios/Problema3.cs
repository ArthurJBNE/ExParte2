using System;

namespace Exercicios
{
    public class Problema3
    {
        public static void CalcularRendimentoComEntrada()
        {
            Console.WriteLine("Cálculo de Rendimento com Entrada de Dados");
            Console.WriteLine("========================================");

            Console.Write("Digite o Valor Inicial (R$): ");
            decimal valorInicial = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros (%): ");
            decimal taxaJuros = decimal.Parse(Console.ReadLine()) / 100;

            Console.Write("Digite o Período (meses): ");
            int periodoMeses = int.Parse(Console.ReadLine());

            decimal saldoAtual = valorInicial;
            decimal rendaAcumulada = valorInicial;

            Console.WriteLine("\nEvolução do Investimento:");
            Console.WriteLine("Mês | Saldo Atual | Rendimento | Renda Acumulada");
            Console.WriteLine("----|-------------|------------|-----------------");

            for (int mes = 1; mes <= periodoMeses; mes++)
            {
                decimal rendimento = saldoAtual * taxaJuros;
                decimal rendimentoLiquido = rendimento - (rendimento * 0.15M); // 15% de imposto
                saldoAtual += rendimentoLiquido;
                rendaAcumulada = Math.Round(saldoAtual + rendimentoLiquido, 2);

                Console.WriteLine($"{mes,3} | R$ {saldoAtual,9:F2} | R$ {rendimentoLiquido,9:F2} | R$ {rendaAcumulada,9:F2}");
            }
        }
    }
} 