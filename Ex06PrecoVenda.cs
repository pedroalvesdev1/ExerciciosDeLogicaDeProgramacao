using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex06PrecoVenda
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do custo de fábrica: ");
            double custoFabrica = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do percentual de lucro: ");
            double percentualLucro = Convert.ToDouble(Console.ReadLine());

            double percentualImpostos = (45.0 / 100) * custoFabrica;
            double visaoaLucro = custoFabrica * (percentualLucro / 100);
            double valorVenda = custoFabrica + visaoaLucro + percentualImpostos;

            Console.WriteLine($"O valor de vendam do produto é {valorVenda.ToString("C2")}");
        }
    }
}
