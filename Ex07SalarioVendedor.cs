using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosGemini
{
    internal class Ex07SalarioVendedor
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o salário do vendedor:");
            double salarioVendedor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o total das vendas:");
            double vendasTotal = Convert.ToDouble(Console.ReadLine());

            double valorComissao = vendasTotal * (2.0 / 100);
            double salarioTotal = salarioVendedor + valorComissao;

            Console.WriteLine($"O slári ao total é {salarioTotal.ToString("C2")}");
        }
    }
}
