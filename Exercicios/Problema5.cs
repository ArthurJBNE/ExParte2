using System;

namespace Exercicios
{
    public class Problema5
    {
        public static void CalcularValorPresente()
        {
            decimal valorFuturo = 7390.61M;
            decimal taxaJuros = 0.05M;
            int periodoMeses = 12;

            decimal valorPresente = valorFuturo / (decimal)Math.Pow(1 + (double)taxaJuros, periodoMeses);

            Console.WriteLine($"Valor Futuro: R$ {valorFuturo:F2}");
            Console.WriteLine($"Taxa de Juros: {taxaJuros:P2}");
            Console.WriteLine($"Período: {periodoMeses} meses");
            Console.WriteLine($"Valor Presente: R$ {valorPresente:F2}");
        }
    }
} 