using System;

namespace ExerciciosGemini
{
    internal class Ex33ContaEnergia
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de kWh você utilizou: ");
            double kwhCliente = Convert.ToDouble(Console.ReadLine());

            const double valorAte = 0.50;
            const double valorAcima = 0.75;

            if (kwhCliente < 101)
            {
                double valorConta = kwhCliente * valorAte;
                Console.WriteLine($"O valor total a ser pago é {valorConta.ToString("C2")}.");
            }
            else
            {
                double valorConta = kwhCliente * valorAcima;
                Console.WriteLine($"O valor total a ser pago é {valorConta.ToString("C2")}.");
            }
        }
    }
}