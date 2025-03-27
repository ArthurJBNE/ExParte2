using System;

namespace ExerciciosFinanceiros
{
    public class Problema4
    {
        public static void CalcularRendimentoComResgate()
        {
            Console.WriteLine("Cálculo de Rendimento com Resgate");
            Console.WriteLine("================================");

            Console.Write("Digite o Valor Presente (R$): ");
            decimal valorPresente = decimal.Parse(Console.ReadLine());

            Console.Write("Digite a Taxa de Juros mensal (%): ");
            decimal taxaJuros = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o Período total (meses): ");
            int periodoMeses = int.Parse(Console.ReadLine());

            Console.Write("Digite o mês do resgate: ");
            int mesResgate = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor do resgate (R$): ");
            decimal valorResgate = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nDados informados:");
            Console.WriteLine($"Valor Presente: R$ {valorPresente:F2}");
            Console.WriteLine($"Taxa de Juros: {taxaJuros}%");
            Console.WriteLine($"Período: {periodoMeses} meses");
            Console.WriteLine($"Resgate no mês {mesResgate}: R$ {valorResgate:F2}");

            Console.WriteLine("\nTeste de Mesa:");
            Console.WriteLine("Mês | Valor Presente | Rendimento | Resgate | Saldo Final");
            Console.WriteLine("----|----------------|------------|----------|-------------");

            decimal saldo = valorPresente;

            for (int mes = 1; mes <= periodoMeses; mes++)
            {
                decimal rendimento = saldo * (taxaJuros / 100);
                decimal saldoAnterior = saldo;
                
                if (mes == mesResgate)
                {
                    saldo -= valorResgate;
                }
                
                saldo += rendimento;

                Console.WriteLine($"{mes,3} | R$ {saldoAnterior:F2} | R$ {rendimento:F2} | {(mes == mesResgate ? $"R$ {valorResgate:F2}" : "R$ 0,00")} | R$ {saldo:F2}");
            }
        }
    }
} 