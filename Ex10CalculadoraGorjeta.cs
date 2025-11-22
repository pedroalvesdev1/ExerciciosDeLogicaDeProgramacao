using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex10CalculadoraGorjeta
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor total da conta: ");
            double totalConta = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor em porcentagem da gorjeta: ");
            double percentualGorjeta = Convert.ToDouble(Console.ReadLine());


            double valorTotal = totalConta + ((percentualGorjeta / 100) * totalConta);

            Console.WriteLine($"O valor final da conta ju8nto da gorjeta é {valorTotal.ToString("C2")}");

        }
    }
}
