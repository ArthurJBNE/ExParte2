using System;

namespace Exercicios
{
    public class Problema4
    {
        public static void CalcularRendimentoComResgate()
        {
            decimal valorInicial = 1000.00M;
            decimal taxaJuros = 0.05M;
            decimal saldoAtual = valorInicial;
            decimal rendaAcumulada = valorInicial;

            Console.WriteLine($"Valor Inicial: R$ {valorInicial:F2}");
            Console.WriteLine($"Taxa de Juros: {taxaJuros:P2}");
            Console.WriteLine("\nEvolução do Investimento com Resgate:");
            Console.WriteLine("Mês | Saldo Atual | Rendimento | Resgate | Renda Acumulada");
            Console.WriteLine("----|-------------|------------|---------|-----------------");

            for (int mes = 1; mes <= 6; mes++)
            {
                decimal rendimento = saldoAtual * taxaJuros;
                decimal rendimentoLiquido = rendimento - (rendimento * 0.15M); // 15% de imposto
                decimal resgate = mes == 3 ? 200.00M : 0.00M; // Resgate no 3º mês
                saldoAtual += rendimentoLiquido - resgate;
                rendaAcumulada = Math.Round(saldoAtual + rendimentoLiquido, 2);

                Console.WriteLine($"{mes,3} | R$ {saldoAtual,9:F2} | R$ {rendimentoLiquido,9:F2} | R$ {resgate,7:F2} | R$ {rendaAcumulada,9:F2}");
            }
        }
    }
} 