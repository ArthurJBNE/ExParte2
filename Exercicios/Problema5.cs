using System;

namespace ExerciciosFinanceiros
{
    public class Problema5
    {
        public static void CalcularValorPresente()
        {
            decimal valorFuturo = 7390.61M;
            int periodoAnos = 2;
            decimal taxaAnual = 5.30M;

            Console.WriteLine("Cálculo para obter Valor Futuro de R$ 7.390,61");
            Console.WriteLine("=============================================");
            Console.WriteLine($"Valor Futuro Desejado: R$ {valorFuturo:F2}");
            Console.WriteLine($"Período: {periodoAnos} anos");
            Console.WriteLine($"Taxa Anual: {taxaAnual}%");

            // Cálculo do Valor Presente necessário
            decimal taxaDecimal = taxaAnual / 100;
            decimal valorPresente = valorFuturo / (decimal)Math.Pow(1 + (double)taxaDecimal, periodoAnos);

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Valor Presente necessário: R$ {valorPresente:F2}");

            // Teste de Mesa detalhado
            Console.WriteLine("\nTeste de Mesa (ano a ano):");
            Console.WriteLine("Ano | Valor Inicial | Juros | Valor Final");
            Console.WriteLine("----|---------------|--------|------------");

            decimal saldoAtual = valorPresente;
            for (int ano = 1; ano <= periodoAnos; ano++)
            {
                decimal juros = saldoAtual * taxaDecimal;
                decimal valorFinalAno = saldoAtual + juros;
                
                Console.WriteLine($"{ano,3} | R$ {saldoAtual:F2} | R$ {juros:F2} | R$ {valorFinalAno:F2}");
                
                saldoAtual = valorFinalAno;
            }

            // Verificação
            Console.WriteLine("\nVerificação:");
            Console.WriteLine($"Valor Presente: R$ {valorPresente:F2}");
            Console.WriteLine($"Taxa: {taxaAnual}% a.a.");
            Console.WriteLine($"Período: {periodoAnos} anos");
            Console.WriteLine($"Valor Futuro calculado: R$ {saldoAtual:F2}");
            Console.WriteLine($"Diferença: R$ {Math.Abs(valorFuturo - saldoAtual):F2}");
        }
    }
} 