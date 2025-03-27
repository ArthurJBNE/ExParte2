using System;

namespace ExerciciosFinanceiros
{
    public class Problema2
    {
        public static void CalcularRendimentoMensal()
        {
            Console.WriteLine("Cálculo de Rendimento Mensal");
            Console.WriteLine("===========================");

            Console.Write("Digite o Valor Presente (R$): ");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros mensal (%): ");
            decimal taxaJuros = decimal.Parse(Console.ReadLine());

            const int periodoMeses = 6;

            Console.WriteLine("\nDados informados:");
            Console.WriteLine($"Valor Presente: R$ {valorPresente:F2}");
            Console.WriteLine($"Taxa de Juros mensal: {taxaJuros}%");
            Console.WriteLine($"Período: {periodoMeses} meses");
            
            Console.WriteLine("\nTeste de Mesa:");
            Console.WriteLine("Período | Taxa Juros | Rend. Líquido | Rendimento");
            Console.WriteLine("--------|------------|---------------|----------------");

            decimal saldoAtual = valorPresente;
            decimal rendaAcumulada = valorPresente;
            decimal taxaDecimal = taxaJuros / 100;

            for (int mes = 1; mes <= periodoMeses; mes++)
            {
                decimal rendimentoLiquido = Math.Round(saldoAtual * taxaDecimal, 2);
                rendaAcumulada = Math.Round(saldoAtual + rendimentoLiquido, 2);
                
                Console.WriteLine($"{mes,7} | {taxaJuros,9:F2}% | R$ {rendimentoLiquido,11:F2} | R$ {rendaAcumulada,13:F2}");
                
                saldoAtual = rendaAcumulada;
            }

            decimal rendimentoTotal = rendaAcumulada - valorPresente;

            Console.WriteLine("\nResumo:");
            Console.WriteLine($"Valor Inicial: R$ {valorPresente:F2}");
            Console.WriteLine($"Rendimento Total: R$ {rendimentoTotal:F2}");
            Console.WriteLine($"Valor Final: R$ {rendaAcumulada:F2}");
        }
    }
} 