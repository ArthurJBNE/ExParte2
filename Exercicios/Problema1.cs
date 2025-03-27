using System;

namespace Exercicios
{
    public class Problema1
    {
        public static void CalcularRendimento()
        {
            decimal valorInicial = 1000.00M;
            decimal taxaJuros = 0.05M;
            int periodoMeses = 12;

            decimal rendimento = valorInicial * taxaJuros * periodoMeses;
            decimal montante = valorInicial + rendimento;

            Console.WriteLine($"Valor Inicial: R$ {valorInicial:F2}");
            Console.WriteLine($"Taxa de Juros: {taxaJuros:P2}");
            Console.WriteLine($"Período: {periodoMeses} meses");
            Console.WriteLine($"Rendimento: R$ {rendimento:F2}");
            Console.WriteLine($"Montante: R$ {montante:F2}");
        }
    }
} 