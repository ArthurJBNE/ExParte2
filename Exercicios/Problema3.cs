using System;

namespace ExerciciosFinanceiros
{
    public class Problema3
    {
        public static void CalcularRendimentoEntrada()
        {
            Console.WriteLine("Cálculo de Rendimento com Entrada de Dados");
            Console.WriteLine("========================================");

            Console.Write("Digite o Valor Presente: R$ ");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros (%): ");
            decimal taxaJuros = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o Período (anos): ");
            int periodoAnos = int.Parse(Console.ReadLine());

            // Cálculo do rendimento
            decimal taxaDecimal = taxaJuros / 100;
            decimal valorFuturo = valorPresente * (decimal)Math.Pow(1 + (double)taxaDecimal, periodoAnos);
            decimal rendimento = valorFuturo - valorPresente;

            Console.WriteLine("\nResultados:");
            Console.WriteLine("===========");
            Console.WriteLine($"Valor Presente: R$ {valorPresente:F2}");
            Console.WriteLine($"Taxa de Juros: {taxaJuros}%");
            Console.WriteLine($"Período: {periodoAnos} anos");
            Console.WriteLine($"Rendimento: R$ {rendimento:F2}");
            Console.WriteLine($"Valor Futuro: R$ {valorFuturo:F2}");
        }
    }
} 