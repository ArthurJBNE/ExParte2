using System;

namespace ExerciciosFinanceiros
{
    public class Problema1
    {
        public static void CalcularRendimento()
        {
            Console.WriteLine("Cálculo de Rendimento de Investimento");
            Console.WriteLine("====================================");
            
            Console.Write("Digite o Valor Presente (R$): ");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros (%): ");
            decimal taxaJuros = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o Período (meses): ");
            int periodoMeses = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados informados:");
            Console.WriteLine($"Valor Presente: R$ {valorPresente:F2}");
            Console.WriteLine($"Taxa de Juros: {taxaJuros}%");
            Console.WriteLine($"Período (meses): {periodoMeses}");

            decimal taxaDecimal = taxaJuros / 100;
            decimal valorFuturo = valorPresente * (decimal)Math.Pow(1 + (double)taxaDecimal, periodoMeses);

            Console.WriteLine($"\nValor Futuro: R$ {valorFuturo:F2}");
            
            // Teste de Mesa
            Console.WriteLine("\nTeste de Mesa:");
            Console.WriteLine("valorPresente | taxaJuros | periodoMeses | Valor F");
            Console.WriteLine("-------------|-----------|--------------|----------");
            Console.WriteLine($"R$ {valorPresente:F2} | {taxaJuros:F2}% | {periodoMeses} | R$ {valorFuturo:F2}");
        }
    }
} 